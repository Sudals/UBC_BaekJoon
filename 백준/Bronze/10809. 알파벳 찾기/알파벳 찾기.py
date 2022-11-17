s = input()
alphabet = 'abcdefghijklmnopqrstuvwxyz'
res = ''
for i in alphabet:
    if i in s:
        index = s.find(i)
        res=res+str(index)+" ";
    else:
        res+="-1 ";

print(res)