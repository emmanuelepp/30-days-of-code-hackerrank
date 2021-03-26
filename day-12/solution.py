# Ctor
def __init__(self, firstName, lastName, idNum, scores):
    self.firstName = firstName
    self.lastName = lastName
    self.idNumber = idNum
    self.scores = scores


# Calculate Method
def calculate(self):

    ave = 0
    ave = self.scores

    ave = sum(ave) / len(ave)

    if ave >= 90 and ave <= 100:
        return 'O'
    elif ave >= 80 and ave <= 90:
        return 'E'
    elif ave >= 70 and ave <= 80:
        return 'A'
    elif ave >= 55 and ave <= 70:
        return 'P'
    elif ave >= 40 and ave <= 55:
        return 'D'
    elif ave <= 40:
        return 'T'

    return '0'
