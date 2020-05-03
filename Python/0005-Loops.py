"""----------------------------------------------------------------"""
"""------------------------------TASK------------------------------"""
""" Read an integer N. For all non-negative integers i <, N,       """
""" print i^2.                                                     """
""" See the sample for details.                                    """
"""----------------------------------------------------------------"""

n: int = int(input())

i: int
for i in range(0, n):
    if i >= 0:
        print(i**2)
