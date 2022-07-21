namespace git_branchs.Entities;

public class User {
    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set;}

    public void SetEmail(string email){
        if(string.IsNullOrEmpty(email)){
            throw new ArgumentException("The email must not be empty");
        }
    }
}