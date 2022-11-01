let arr=[1,2,3,4,5,16];
let sum=0;
let max=arr[0];
let min=arr[1];
for(i=0;i<arr.length;i++){
    sum+=arr[i];
    if(arr[i]>max){
        max=arr[i];
        continue;
    }else if(arr[i]<min){
        min=arr[i];
        continue;
    }console.log(sum);
}