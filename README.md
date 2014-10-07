Coding Requirements

You will first add the LinkedListCell class used in lab (see Lab 13). You do not
need to modify this class. To add a new class to a Visual Studio project:

- Right-click on the project name in the Solution Explorer
- Select Add->New Item
- Select Class, and type the name of the class in the text box at the bottom
- Click Add
- The new class should now appear in the Solution Explorer, and its code

window should open for you to modify
For LinkedListCell, copy the code from Lab 13 (from “public class
LinkedListCell” down to just before the last bracket) and paste it into the code
window for that class. Make sure the namespace listed in the file is for THIS project,
not for Lab 13.
Next, add the class PhoneCount using the process above (you will develop this
class from scratch). This class should contain:
- Fields for a phone number and a count for how many times that number was
called
- A property to get the phone number, and a property to get and set the count
- A constructor to take values for the fields and initialize them
- Finally, you will modify the UserInterface class to add functionality to the GUI.
You may organize your code however you wish subject to the following requirements:
- You should have fields for the two linked lists of phone numbers (both should
be type LinkedListCell<PhoneCount>
- For each input file, you should read the phone numbers into the corresponding
linked list. Each phone number (and count) should be stored in a separate cell
in the list. If you read a number that you have seen previously in that file, be
sure to update the count of the corresponding PhoneCount object instead of
creating a new object.
- When finding overlaps, you should search through the first linked list looking
for numbers that meet the minimum count. When you find one, search also
through the second linked list to see if you can find a matching number that
also meets the minimum.
