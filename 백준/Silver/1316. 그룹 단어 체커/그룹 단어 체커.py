num = int(input())
total = 0
isCheck=False
arr=[]
tmp=[' ']
for i in range(num):    
    arr.append(list(input().strip()))
    isCheck=False
    tmp.clear()
    tmp=[' ']
    for j in range(len(arr[i])):
        if arr[i][j] in tmp:
            if arr[i][j] !=tmp[len(tmp)-1]:
                isCheck=False
                break;
        else:
            tmp.append(arr[i][j])
            isCheck = True
    if isCheck:
        total+=1
print(total)
    
