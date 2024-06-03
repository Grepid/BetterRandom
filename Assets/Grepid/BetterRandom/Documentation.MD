# <font color = #00FFFF>Better Random **Small** Documentation</font>
It doesn't allow me to put angled brackets for type declaration on things like ICollection. So -type- will be the equivalent in the documentation.
## <font color=#00FF00>Weighted</font>

### <font color = #f5dd42>RandomFromCollection</font>
RandomFromCollection(ICollection-T- objects , string weightFieldName) takes a Collection of T and given a field name, can use that field name to make a weighted decision as to which element to return.

Also has an Override RandomFromCollection(ICollection-T- objects , string weightFieldName , int repetitions , bool noDupes) that returns T[]. With the repetitions and noDupes you can set it to do the random weight check x amount of times with repetition and you can choose to allow the same element to be selected more than once with noDupes set to false. If you have noDupes set to true, your repetitions *must* be less than or equal to the number of elements in your collection.

### <font color = #f5dd42>ToWeights</font>
ToWeights(ICollection-T- , string fieldName) takes in a Collection of objects, and given a field name for a float will return an array with the same order as entered, but with floats from the field instead of initial T. (Useful for converting a collection of Class Instances to an array of their weights. Can technically also be used for any other float variable if you really want and need :) )

### <font color = #f5dd42>RandomIndex</font>
RandomIndex(ICollection-float- weights) gives you the index of a chosen element from the collection of floats passed in. Useful in a scenario where you want to spawn an Item, you can do:<br/>
`Item[] items;`<br/>
`int index = RandomIndex(ToWeights(items , "spawnChance"));`<br/>
`Item chosenItem = items[index];`<br/>
This has an array of items to spawn, and chooses a random index based on a variable in the Item class called "spawnChance".

RandomIndex(ICollection-float- weights , int repetitions , bool noDupes) Same as RandomIndex without overrides, except allows you do get an array of indexes it selects. Controls are the same as RandomFromCollection repetitions. 

### <font color = #f5dd42>FlipValues</font>


### <font color = #f5dd42>ShiftValuesToPositive</font>

### <font color = #f5dd42>ShiftValuesToNegative</font>

### <font color = #f5dd42>AbsWeights</font>

## <font color=#00FF00>Rand</font>

### <font color = #f5dd42>RandomFromCollection</font>