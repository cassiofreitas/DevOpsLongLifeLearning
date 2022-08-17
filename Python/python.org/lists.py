cubes = [1,8,27,65,81,100]
cubes[3] = 64   # 65 is wrong; cube of 4 is 64
print(cubes)
cubes.append(7 ** 3)
print(cubes)

#replacing and slicing lists

letters=['a', 'b' ,'c', 'd', 'e', 'f', 'g']
print(letters)

letters[2:5] = ['C', 'D', 'E']  #replace
print(letters)

letters[2:5] = []   #delete elements
print(letters)

letters[:]=[]   #clear list
print(letters)

letters[2:5] = ['C', 'D', 'E']
print(len(letters))

a = [ 'a', 'b', 'c' ] 
n = [1,2,3]
x = [ a,n ]     #nested list
print(a,'\n',n,'\n',x)

print(x[0])
print(x[0][1])  #sounds like two(2) dimensions

