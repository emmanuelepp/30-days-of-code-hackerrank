import math
import os
import random
import re
import sys

if __name__ == '__main__':

    n = int(input())
count = 0
num = '{0:8b}'.format(n)

intMap = map(int, num.strip())

listNum = list(intMap)
print(listNum)
for i in range(len(listNum)):
    if listNum[i] == 1:
        count = count + 1
    elif listNum[i] == 0:
        break

print(count)
