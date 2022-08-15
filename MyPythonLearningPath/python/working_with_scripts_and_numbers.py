num = "2"

print( num + num)
print( type(num))

num = "12"
print( num * 3)

#print(num * num)    #does not work; raises an error
#print(num + 3)      #does not work; raises an error

# converting Strings to Numbers

num = input("Enter a number to be doubled: ")
doubled_num = num*2
print(doubled_num)

num = "12"
doubled_num = 12.01
print (int(num))
print(float(num))
print("Converting from int or float to str " + str(doubled_num) + " works.")

#exercise

num1 = input("Enter first number: ")
num2 = input("Enter second number: ")

int_num1 = int(num1)
int_num2 = int(num2)

print("The product of " + str(int_num1) + " and " + str(int_num2) + " is " + str(float(int_num1 * int_num2)) + ".")


# exercise

weight=0.2
animal = "newt"

print(f"{weight} kg is the weight of the {animal}.")
print("{} kg is the weight of the {}.".format(weight,animal))

# find a string in a string

phrase = "the surprise is in here somewhere"
print(phrase.find("surprise"))