#wap a programme to find if an entered year is a leap year or not
year=int(input('Enter a year'))
def leap():
    if year%400==0 and year%100==0:
        print("Leap year")
    elif year%4==0 and year%100!=0:
        print("Leap year")
    else:
        print("Not a Leap year")
leap()