using System;

public class PhoneCount
{
    private int _phoneNumber = 0; // The phone number
    private int _count = 0; // How many times the number was called

    /// <summary>
    /// Getter and setter for _phoneNumber
    /// </summary>
    public int PhoneNumber
    {
        get
        {
            return _phoneNumber;
        }
        set
        {
            _phoneNumber = value;
        }
    }

    /// <summary>
    /// A constructor to take values for the fields and initialize them
    /// </summary>
    /// <param name="p">the phone number</param>
    /// <param name="c">the count</param>
    public PhoneCount(int p, int c)
    {
        _phoneNumber = p;
        _count = c;
    }
}


// Fields for a phone number and a count for how many times that number was
// called
// A property to get the phone number, and a property to get and set the count
// A constructor to take values for the fields and initialize them