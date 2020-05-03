"""----------------------------------------------------------------"""
"""------------------------------TASK------------------------------"""
""" You are given the year, and you have to write a function to    """
""" check if the year is leap or not.                              """
""" Note that you have to complete the function and remaining code """
""" is given as template.                                          """
"""----------------------------------------------------------------"""


def is_leap(year: int):
    leap: bool = False
    if year % 4 == 0:
        if year % 100 == 0 and not year % 400 == 0:
            leap = False
        else:
            leap = True
    return leap


year: int = int(input())
print(is_leap(year))
