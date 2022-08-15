from fcntl import DN_DELETE


response = input("Tell me your password: ")
first_letter = response.strip()[0:1].upper()

print("The first letter you entered was:" + first_letter )
