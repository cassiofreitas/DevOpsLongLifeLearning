from os import system
cls = lambda: system('clear')

cls()

x = int(input("Please enter an integer: "))
if x < 0:
    x=0
    print('Negative changed to zero')
elif x == 0:
    print('Zero')
elif x == 1:
    print('Single')
else:
    print('More')

print('---'*5,'for loop in python')

words = [ 'cat', 'window','defenestrate']
for w in words:
    print(w,len(w))

print('---'*5,'collection in python')
users={ 'Hans': 'active', 'Éléonore': 'inactive', '景太郎': 'active' }

#strategy iterate over a copy
for user, status in users.copy().items():
    if status == 'inactive':
        del users[user]
print('iterate over a copy:')
print(users)

#strategy: create a new collection
active_users = {}
for user, status in users.items():
    if status == 'active':
        active_users[ user ] = status
print('create an fill another collection:')
print(active_users)

#iterate over a sequence of numbers.
for i in range(5):  #the endpoin (here 5) is never part of the range
    print(i)

print( list(range(5,10)))   #forces initial number
print(list(range(0,10,3)))  #defines step=3 and start=0
print(list(range(-10,-100,-30)))    #defines step=-30 and start=-10

#To iterate over the indices of a sequence, you can combine range() and len() as follows:
#further, we will learn to use enumerate()

a=['Mary', 'had', 'a', 'little', 'lamb']
for i in range(len(a)):
    print(i,a[i])

#lists, iterable elements (see further)
print (range(0,10)) #it does not generate the list itself; it is an object
print(sum(range(4)))    #sum uses the range object as iterable source

#4.4. break and continue Statements, and else Clauses on Loops¶
print('='*15)
print('break, continue and else clause on loops')

for n in range(2,10):
    for x in range(2,n):
        if n % x == 0:
            print(n,'equals',x,'*',n//x)
            break
    else:   #loop flew through without finding a factor
        print(n,'is a prime number')

for num in (range(2,10)):
    if num % 2 ==0:
        print("Found an even number",num)
        continue
    print("Found an odd number", num)

print('lets test the pass statement = does nothing')
for n in range(1,9):
    pass



