class Array:
    def __init__(self, arr=[]) -> None:
        self.arr = arr
        
    @property
    def array(self):
        return self.arr
    
    def filter(self, callback):
        i = 0
        while i < len(self.arr):
            valor = callback(self.arr[i])
            if valor == False:
                self.arr.pop(i)
            else:
                i += 1
    
    def find(self, callback):
        for x in self.arr:
            valor = callback(x)
            if valor == True:
                return x
            
        return None
    
    def map(self, callback):
        newArr = []
        for x in self.arr:
            if type(x) == int or type(x) == float:
                valor = callback(x)
            else:
                valor = None
            
            newArr.append(valor)
        
        return newArr
    
""" arr1 = Array([1,2,3])
arr1.filter(lambda x: x > 2)
print(arr1.array)

arr2 = Array([1,2,3,4])
value = arr2.find(lambda x: x > 2)
print(value)
 """
arr3 = Array([1,2,'banana',4, 5.4])
newArr = arr3.map(lambda x: x * 2)
print(newArr)


    
