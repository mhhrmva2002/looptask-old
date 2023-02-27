let reqem = 0;
let tersreqem = 0;
let qaliq = 0 ;
while ( reqem > 0){
    if ( reqem == tersreqem){
        qaliq =reqem %10;
        reqem = ( reqem-qaliq )/10;
        tersreqem =( tersreqem *10+qaliq );

    }
}
   console.log(true);