<?php
class Shape
{
    public $sides = 0;
    public $name = " ";

    public function description()
    {
        echo "A $this->name with $this->sides sides.";
    }
}

$myShape1 = new Shape;          // create an object called myShape1 - just once here at this code

$myShape1->sides = 3;           // sets sides property to 3
$myShape1->name = "triangle";   // sets name property to triangle
$myShape1->description();       // call description method
echo "\n";

$myShape1->sides = 4;           // sets sides property to 4
$myShape1->name = "square";   // sets name property to square
$myShape1->description();       // call description method
echo "\n";

$myShape1->sides = 6;           // sets sides property to 6
$myShape1->name = "hexagon";   // sets name property to hexagon
$myShape1->description();       // call description method
echo "\n";
