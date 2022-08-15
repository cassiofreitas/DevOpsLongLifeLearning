# 07/03/2022
from cgi import print_arguments
from re import sub


type("hello, Word")

#String literals
#DIrectly inserted in you code, using delimiters. 
#Examples
string1 = 'Hello, World'	#single quote
string2 = "Hello, World"	#double quotes
string3 = "Hello 'world'"	#both
#string4 = "Hello "rise an error here""	#will rise an error
string5 = "Hello \"avoids error\""	#will work OK, using escapechar
string6 = "Hello, you're the #1!"	#works OK.

#using len()
print(len(string5))

#multiline strings, using \ to finish every line
paragraph = "This planet has—or rather had—a problem, which was \
this: most of the people living on it were unhappy for pretty much \
of the time. Many solutions were suggested for this problem, but \
most of these were largely concerned with the movements of small \
green pieces of paper, which is odd because on the whole it wasn't \
the small green pieces of paper that were unhappy."
print(paragraph) 

#multilne strings, using """ or '''
#this version will print the string with the same original line brakes
paragraph = """This planet has—or rather had—a problem, which was
this: most of the people living on it were unhappy for pretty much
of the time. Many solutions were suggested for this problem, but
 most of these were largely concerned with the movements of small
  green pieces of paper, which is odd because on the whole it wasn't
   the small green pieces of paper that were unhappy."""
print(paragraph)

# operations with strings
# Concatenation (join), indexing (gets a single char), slicing (gets several chars)
# Concatenation
magic_string = string1 + string2
print( magic_string)

first_name="Arthur"
last_name="Dent"
full_name = first_name + " " + last_name

print(full_name)

#indexing []
#Python strings "index" starts at 0 - zero
flavor = "fig pie"
print(flavor[1])	#second char
print(flavor[0])	#first char

#using negative index
print(flavor[-7])
print(flavor[-6])

#importance of negative index
user_input="User input"		#how to get the last char?
#solution 1 = calculating the index, using len()
final_index = len(user_input)-1
last_character = user_input[final_index]
print(last_character)
#solution 2 = using negative index
last_character = user_input[-1] 
print(last_character)

#slicing (substrings) = slices
print(flavor[0:3])	#starts at zero AND GOES TO [2]; [3] is not part of the slice
print(flavor[3:7])	#starts at 3 AND GOES TO [6]
print(flavor[:14])	#no error; Python is wise and return the slice (the whole string in this case)

# strings are immutable :-O
# attention: not the whole string, but elements
word="goal"

word="f" + word[1:]
print(word);
##word[0]='T'	#will rise and error

#exercise = slice zinga from bazinga
ex1='bazinga'
answer=ex1[2:len(ex1)-1]	#attention to pecuriliarites of slices (already discussed).
print(answer)

#Strings manipulation via .methods
#
name = "Jean-Luc Picard"
print(name.lower())
print(name.upper())
print(len(name))

#removing spaces from strings
name = "   Jean-Luc Picard   "
print('[' + name.lstrip() + ']') #left removal
print('[' + name.rstrip() + ']') #right removal
print('[' + name.strip() + ']') #left and right removal

#Determine If a String Starts or Ends With a Particular String
starship="Enterprise"

print(starship.startswith("en")) #false
print(starship.startswith("En")) #true
print(starship.endswith("risE")) #false
print(starship.endswith("rise")) #true

#immutability for string chars

name="Picard"

print(name.upper())  #original string not changed
print(name)

name = name.upper()
print(name)

#discover new string methods.

starship="Enterprise"
print(starship.casefold())
print('------------')

#exercise
ex1="Animals"
ex2="Badger"
ex3="Honey Bee"
ex4="Honey Badger"

print(ex1.lower())
print(ex2.lower())
print(ex3.lower())
print(ex4.lower())

print(ex1.upper())
print(ex2.upper())
print(ex3.upper())
print(ex4.upper())

string1 = "Filet Mignon"
string2 = "Brisket"
string3 = "Cheeseburger"

string1 = string1.lstrip()
string2 = string2.rstrip()
string3 = string3.strip()

print("[" + string1 + "]\n[" + string2 + "]\n[" + string3 + "]\n")

print('----------------------')

string1 = "Becomes"
string2 = "becomes"
string3 = "BEAR"
string4 = "bEautiful"

print(string1.startswith("be"))
print(string2.startswith("be"))
print(string3.startswith("be"))
print(string4.startswith("be"))

string1=string1.casefold()
string2=string2.casefold()
string3=string3.casefold()
string4=string4.casefold()

print("strings were .casefold()ed")

print(string1.startswith("be"))
print(string2.startswith("be"))
print(string3.startswith("be"))
print(string4.startswith("be"))

