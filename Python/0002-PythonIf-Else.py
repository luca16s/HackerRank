"""----------------------------------------------------------------"""
"""------------------------------TASK------------------------------"""
""" Given an integer, , perform the following conditional actions: """
""" If number is odd, print Weird                                  """
""" If number is even and in the inclusive range of 2 to 5,        """
""" print Not Weird                                                """
""" If number is even and in the inclusive range of 6 to 20, print """
""" Weird                                                          """
""" If number is even and greater than 20, print Not Weird         """
"""----------------------------------------------------------------"""

# !/bin/python3

n: int = int(input())
isOdd: int = n % 2

if not isOdd == 0 or n == 1:
    print('Weird')
elif isOdd == 0 and 2 <= n <= 5:
    print('Not Weird')
elif isOdd == 0 and 6 <= n <= 20:
    print('Weird')
elif isOdd == 0 and n > 20:
    print('Not Weird')
