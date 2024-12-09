const array1 = [5, 12, 8, 130, 44]

function find (arr, elemento){
    
    for (let i = 0; i < arr.length; i++ ){
        if (elemento(arr[i], i, arr )){
            return arr[i]
        } else {return undefined}

        
    }
}

const resultado = find(array1, (arr) => arr > 10 )
console.log(resultado)