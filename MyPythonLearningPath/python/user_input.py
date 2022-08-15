# learning to deal with user inputs
prompt="Hey, what's up? "
user_input=input(prompt)        #always returns a String
print("You said: " + user_input)

print('--------------------')

response = input("What should I shout? ")
shouted_response = response.upper()
whisper_response = response.lower()

# I just found str function searching on Google
# Here: https://pythonprinciples.com/
count_response = str(len(response))

print("Shouted: " + shouted_response)
print("Whisper: " + whisper_response)
print("Counted: " + count_response)


