using System;

public class PhoneCount
{
    private string _phoneNumber = null; // The phone number
    private int _count = 0; // How many times the number was called

    /// <summary>
    /// Getter for _phoneNumber
    /// </summary>
    public string PhoneNumber
    {
        get
        {
            return _phoneNumber;
        }

    }

    /// <summary>
    /// Getter and setter for _count
    /// </summary>
    public int Count
    {
        get
        {
            return _count;
        }
        set
        {
            _count = value;
        }
    }

    /// <summary>
    /// A constructor to take values for the fields and initialize them
    /// </summary>
    /// <param name="p">the phone number</param>
    /// <param name="c">the count</param>
    public PhoneCount(string p, int c)
    {
        _phoneNumber = p;
        _count = c;
    }
}


// Fields for a phone number and a count for how many times that number was
// called
// A property to get the phone number, and a property to get and set the count
// A constructor to take values for the fields and initialize them