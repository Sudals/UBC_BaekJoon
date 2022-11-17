s = int(input())
res =""
for i in range(s):
    a = input().split(' ')
    for j in range(len(a[1])):
        res=res+a[1][j]*int(a[0])
    res=res+'\n'
print(res)
