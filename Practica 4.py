import random

DICE_ART = {
    1: (
        "┌─────────┐",
        "│         │",
        "│    ●    │",
        "│         │",
        "└─────────┘",
    ),
    2: (
        "┌─────────┐",
        "│  ●      │",
        "│         │",
        "│      ●  │",
        "└─────────┘",
    ),
    3: (
        "┌─────────┐",
        "│  ●      │",
        "│    ●    │",
        "│      ●  │",
        "└─────────┘",
    ),
    4: (
        "┌─────────┐",
        "│  ●   ●  │",
        "│         │",
        "│  ●   ●  │",
        "└─────────┘",
    ),
    5: (
        "┌─────────┐",
        "│  ●   ●  │",
        "│    ●    │",
        "│  ●   ●  │",
        "└─────────┘",
    ),
    6: (
        "┌─────────┐",
        "│  ●   ●  │",
        "│  ●   ●  │",
        "│  ●   ●  │",
        "└─────────┘",
    ),
}
DIE_HEIGHT = len(DICE_ART[1])
DIE_WIDTH = len(DICE_ART[1][0])
DIE_FACE_SEPARATOR = " "

def roll_dice():
    return random.randint(1, 6)

def display_dice(die_value):
    if die_value in DICE_ART:
        die_face = DICE_ART[die_value]
        for line in die_face:
            print(line)

def main():
    print("Dice Rolling")
    rolls = int(input("How many times do you want to roll the dice? "))
    results = []
    
    for i in range(rolls):
        die_value = roll_dice()
        results.append(die_value)
        display_dice(die_value)
        print(f"Roll {i+1}: {die_value}")
        print()
    
    # Calcular porcentajes
    print("Percentages:")
    for num in range(1, 7):
        percentage = (results.count(num) / rolls) * 100
        print(f"{num}: {percentage:.1f}%")
        
	

if __name__ == "__main__":
    main()

