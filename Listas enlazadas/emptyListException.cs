public class emptyListException: ApplicationException{
    public emptyListException(string name):base("List named"+name+"is empty")
    {

    }
}