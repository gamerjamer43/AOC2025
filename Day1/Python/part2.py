# starts at 50
pointingAt: int = 50

# password is the number of times it PASSES zero
passesOfZero: int = 0

with open("code.txt", "r") as file:
    for line in file.readlines():
        # first char is dir
        dirstr: str = line[0]

        # second is degrees
        steps: int = int(line[1:])

        # -1 if left, 1 if right
        dir = 1 if dirstr == "R" else -1

        # step each step individually (this sucks but it is what it is)
        for _ in range(steps):
            pointingAt = (pointingAt + dir) % 100
            if pointingAt == 0: passesOfZero += 1

print("Amt of times it was zero:", passesOfZero)