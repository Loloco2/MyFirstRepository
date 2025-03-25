import cv2
import cv2.data
import numpy as np

imagen = cv2.imread('lentes3.png', cv2.IMREAD_UNCHANGED)

cap = cv2.VideoCapture(0)
face_cascade = cv2.CascadeClassifier(cv2.data.haarcascades + 'haarcascade_frontalface_default.xml')

while True:
    ret, frame = cap.read()
    if not ret:
        break

    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

    faces = face_cascade.detectMultiScale(gray,scaleFactor=1.1,minNeighbors=5)

    for (x,y,w,h) in faces:
        resized = cv2.resize(imagen,(w,h))
        b,g,r, alpha = cv2.split(resized) 
        mask = alpha / 255.0
        mask_inv = 1 - mask

        for c in range(0,3):
            frame[y:y+h,x:x+w,c] = (mask_inv * frame[y:y+h,x:x+w,c]) + mask * resized[:,:,c]

        cv2.imshow('filtro',frame)

    if cv2.waitKey(1) & 0xFF == ord('x'):
        break

cap.release()
cv2.destroyAllWindows()