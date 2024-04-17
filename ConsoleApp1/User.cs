namespace ConsoleApp1;

public class User
{
    public string? Name
    {
        get ;
        set ;
    }

    public string? Email
    {
        get ;
        set;
    }

    public string? Ph
    {
        get ;
        set ;
    }
    public override bool Equals(object? obj)
    {
        User Right = obj as User; ///as return null if Casting Fails , no exception will be thrown

        if (Right == null) return false;

        if (this.GetType() != obj.GetType()) return false;

        if (object.ReferenceEquals(this, Right)) return true;

        return (this.Ph == Right.Ph);
    }

    public override string ToString()
    {
        return $"Name:{Name},Email:{Email},Phone Number:{Ph}";
    }
   

}