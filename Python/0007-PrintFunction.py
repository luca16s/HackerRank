"""----------------------------------------------------------------"""
"""------------------------------TASK------------------------------"""
""" Read an integer .                                              """
""" Without using any string methods, try to print the following:  """
"""     Note that "" represents the values in between.             """
"""----------------------------------------------------------------"""


def printNumber(number: int):
    import string
    text: string = ''
    for i in range(0, number):
        text += f'{i + 1}'
    print(text)


n: int = int(input())
printNumber(n)
