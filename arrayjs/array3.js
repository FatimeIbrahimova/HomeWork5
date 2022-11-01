let count=14;
let arr=[3,6,5,3,5,5,4,5,4,3,2,3,6,4];
let max=arr[0];
let min=arr[1];
let force=0;
for(i=0;i<arr.length;i++){
    force=max-min;
    if(arr[i]>max){
        max=arr[i];
    }if(arr[i]<min){
        min=arr[i];
    }
    }
console.log(force);