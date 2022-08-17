a,b = 0,1
while a < 20:
    print(a)
    a,b = b, a+b

#now, printing withou new line after each number
a,b = 0,1
while a < 1000:
    print(a, end=',')
    a,b = b, a+b
