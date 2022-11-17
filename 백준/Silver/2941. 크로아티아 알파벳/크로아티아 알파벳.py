
total = 0
arr = list(input().strip())
lenarr = len(arr)
arr = arr + [0] * 3
for i in range(lenarr):
    if arr[i] == 'c':
        if arr[i + 1] == '=' or arr[i+1]== '-':
            continue
    if arr[i] == 'd':
        if arr[i + 1] == 'z' and arr[i + 2] == '=':
            continue
        elif arr[i + 1] == '-':
            continue
    if arr[i] == 'l':
        if arr[i + 1] == 'j':
            continue
    if arr[i] == 'n':
        if arr[i + 1] == 'j':
            continue
    if arr[i] == 's':
        if arr[i + 1] == '=':
            continue
    if arr[i] == 'z':
        if arr[i + 1] == '=':
            continue
    total = total + 1
print(total)    
