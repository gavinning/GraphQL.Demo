public struct GraphQLModel {

    public static string users = @"
        {
            users {
                username
                role { name }
            }
        }";
}


public class UserType {
    public string username { get; set; }
    public string email { get; set; }
    public RoleType role { get; set; }
}

public class UsersType {
    public UserType[] users { get; set; }
}

public class RoleType {
    public string name { get; set; }
    public string description { get; set; }
}

public class LoginType {
    public UserType user { get; set; }
    public string jwt { get; set; }
}

// Login Model
public class LoginInput {

    public string identifier { get; set; }
    public string password { get; set; }

    LoginInput() { }


    public LoginInput(string username, string password) {
        this.identifier = username;
        this.password = password;
    }
}
