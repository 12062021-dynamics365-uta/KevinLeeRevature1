//Worked with Bishal and Shamal as a group but I did all external way
//and moved the javascript to here as told

//Setting the button to start
let start = document.createElement('button');
document.body.appendChild(start);
start.innerText = 'Start!';

//Setting the event after when the user clicks start
start.addEventListener('click', (e) => {
    let startInput = document.createElement('div');
    startInput.innerText = 'Enter the starting number';
    document.body.appendChild(startInput);  
    let startingNumberInput = document.createElement('input');
    document.body.appendChild(startingNumberInput);   
    let endingNumberInput = document.createElement('input');
    let restart = document.createElement('button');

//Setting the event after when the user types the starting number
    startingNumberInput.addEventListener('keypress', (e) => {
        if(e.key == 'Enter')
        {

            var startingNumber = startingNumberInput.value;
            let endInput = document.createElement('div');
            endInput.innerText = 'Enter the ending number';
            document.body.appendChild(endInput);  
        
            document.body.appendChild(endingNumberInput);       

        }

   //Setting the event after when the user types the ending number and the reset button appears
   endingNumberInput.addEventListener('keypress', (e) => {
        if(e.key == 'Enter')
        {
            var startingNumber = startingNumberInput.value;
            parseInt(startingNumber);
            var endingNumber = endingNumberInput.value;
            parseInt(endingNumber);
            document.body.appendChild(restart);  
           restart.innerText = 'Restart';
        

        restart.addEventListener('click',(e) => {
               location.reload();
           }); 

    let threeSweet = 0; //3 will substitute to "Sweet"
    let fiveSalty = 0; //5 will substitute to "Salty"
    let fifteenSweetnSalty = 0; //Reason of 15 is Least common multiple of 3 and 5 is 15.
                            //Therefore, 15 will substitude to "Sweet' n Salty"

    var array = new Array();


//Number startng at 1 and goes to 1000 by incrementing by single number.
    for (var i = startingNumber; i <= endingNumber; i++)
    {

    //If the difference between the ending number and the starting number is out of range 
    //between 200 and 10000
    //Starting numbers cannot be higher than ending number 
        if((endingNumber - startingNumber) < 200 || (endingNumber - startingNumber) > 10000 || 
        endingNumber < startingNumber) 
        {
            console.log("Invalid Input! Please type the correct input!");
        }
    //Again, 15 will substitute to "Sweet' n Salty". 
        else if (i % 3 == 0 && i % 5 == 0)
        {
            array.push = ("Sweet' n Salty" + " ");
            fifteenSweetnSalty++;
        }

    //5 will substitute to "Salty"
        else if (i % 5 == 0)
        {
            array.push ("Salty, " + " ");
            fiveSalty++;                   
        }

    //3 will substitute to "Sweet"
        else if (i % 3 == 0)
        {
            array.push("Sweet, " + " ");
            threeSweet++;                  
        }

    //Any other numbers will count as numbers.
        else
        {
            array.push(i + " ");                    
        }

    //Every 40 numbers will seperate the group.
        if (i % 40 == 0)
        {
            console.log(array.toString());
            array = [];
        }

    
    }        
    //Count how many time were printed by each.
        console.log(fifteenSweetnSalty + " times 'Sweet' n Salty' were printed.");
        console.log(fiveSalty + " times 'Salty' were printed.");
        console.log(threeSweet + " times 'Sweet' were printed."); 
        }

        });
    });
});
