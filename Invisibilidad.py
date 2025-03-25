import cv2
import numpy as np

cap = cv2.VideoCapture(0)
bg = None

#Colores a borrar
colorBajo = np.array([0,0,0],np.unit8)
colorAlto = np.array([185,255,30],np.unit8)

while True:
    ret, frame = cap.read()
    if ret == False: break

    if bg is None:
        bg = frame

    frameHSV = cv2.cvtColor(frame, cv2.COLOR_BGR2HSV)

    maskColor = cv2.inRange(frameHSV, colorAlto, colorBajo)
    mask = maskColor
    mask = cv2.medianBlur(mask, 13)

    kernel = np.ones((5,5), np.unit8)
    mask = cv2.dilate(mask, kernel, iterations=2)


    area = cv2.bitwise_and(bg,bg, mask=mask)
    maskInv = cv2.bitwise_not(mask)
    SinArea = cv2.bitwise_and(frame, frame, mask=mask)
    frameFinal = cv2.addWeighted(area,1,SinArea,1,0)

    cv2.imshow('Frame', frame)
    cv2.imshow('Efecto', frameFinal)

    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

cap.release()
cv2.destroyAllWindows