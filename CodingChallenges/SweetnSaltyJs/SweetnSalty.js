let threeSweet = 0; //3 will substitute to "Sweet"
let fiveSalty = 0; //5 will substitute to "Salty"
let fifteenSweetnSalty = 0; //Reason of 15 is Least common multiple of 3 and 5 is 15.
                            //Therefore, 15 will substitude to "Sweet' n Salty"
                            
 var array = new Array();                           
console.log("test");

//Number startng at 1 and goes to 1000 by incrementing by single number.
for (var i = 1; i <= 1000; i++)
{
    //Again, 15 will substitute to "Sweet' n Salty". 
    if (i % 3 == 0 && i % 5 == 0)
    {
        array.push("Sweet' n Salty" + " ");
        fifteenSweetnSalty++;
    }

    //5 will substitute to "Salty"
    else if (i % 5 == 0)
   {
        array.push("Salty, " + " ");
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

    //Every 20 numbers will seperate the group.
    if (i % 20 == 0)
    {
        console.log(array.toString());
        array = [];
    }
}        
//Count how many time were printed by each.
console.log(fifteenSweetnSalty + " times 'Sweet' n Salty' were printed.");
console.log(fiveSalty + " times 'Salty' were printed.");
console.log(threeSweet + " times 'Sweet' were printed."); 
