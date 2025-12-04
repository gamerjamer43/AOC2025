# starts at 50
pointingAt: int = 50

# password is the number of times it points at zero
turnsToZero: int = 0

with open("code.txt", "r") as file:
    for line in file.readlines():
        # a turn left past zero = 99
        if line.startswith("L"): pointingAt -= int(line.lstrip("L"))

        # a turn right past 99 = zero
        elif line.startswith("R"): pointingAt += int(line.lstrip("R"))

        # wat
        else: print("wat")

        # wrap your willy
        pointingAt %= 100

        # if zero ah lep lep
        if pointingAt == 0: turnsToZero += 1

print("Amt of times it was zero: " + str(turnsToZero))