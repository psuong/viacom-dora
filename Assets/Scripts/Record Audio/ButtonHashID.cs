using UnityEngine;
using System.Collections;

public class ButtonHashID {

    /// <summary>
    /// Public accessor to retrive the ID.
    /// </summary>
    public int getHashID
    {
        get
        {
            return hashID;
        }
    }

    private int hashID;

    public ButtonHashID(int hashID) {
        this.hashID = hashID;
    }

}
