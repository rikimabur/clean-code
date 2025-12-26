namespace SOLID;
// SRP violation
public class UserService
{
    public string Username { get; set; }
    public string Email { get; set; }

    // Responsibility 1: Manages user data and validation
    private bool ValidateUser()
    {
        if (string.IsNullOrEmpty(Username)) return false;
        if (string.IsNullOrEmpty(Email)) return false;
        // More complex validation logic here
        return true;
    }

    // Responsibility 2: Handles data persistence (logging/saving)
    public void SaveToDatabase()
    {
        if (ValidateUser())
        {
            // Code to save user details to a database
            Console.WriteLine($"Saving user {Username} to database...");
            LogActivity($"User {Username} saved.");
        }
        else
        {
            LogActivity("Failed to save user: validation failed.");
        }
    }

    // Responsibility 3: Handles logging functionality
    private void LogActivity(string message)
    {
        // Code to write log messages to a file, console, or logging service
        Console.WriteLine($"LOG: {message}");
    }
}

//After as SRP-adhering refactoring
public class User
{
    // Only responsibility: Manage user data and state
    public required string Username { get; set; }
    public required string Email { get; set; }
}
public class UserServiceRefactor
{
    // Only responsibility: Handle business logic and validation
    private bool ValidateUser(User user)
    {
        if (string.IsNullOrEmpty(user.Username)) return false;
        if (string.IsNullOrEmpty(user.Email)) return false;
        // Validation logic
        return true;
    }
}
public class UserRepository
{
    // Only responsibility: Handle data access and persistence
    public void Save(User user)
    {
        // Code to save user details to a database
        Console.WriteLine($"Saving user {user.Username} to database...");
    }
}

public class Logger
{
    // Only responsibility: Handle logging
    public void LogActivity(string message)
    {
        // Code to write log messages to a file, console, etc.
        Console.WriteLine($"LOG: {message}");
    }
}