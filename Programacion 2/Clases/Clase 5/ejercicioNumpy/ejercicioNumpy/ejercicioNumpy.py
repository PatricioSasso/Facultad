import numpy as np

arr = np.array([[1,2,3,4],[5,6,7,8]])
print(arr[0:2, 3])
print(arr[0:2, 1:3])
print(arr.shape)
arr = np.array([1,2,3,4], ndmin=5)
print(arr)