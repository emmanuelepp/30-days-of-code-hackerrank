import math
import os
import random
import re
import sys


def factorial(n):

    if n < 1:
        return 1
    else:
        result = n * factorial(n - 1) 
        return result


print(factorial(int(input())))
