
square(10, '@');

Console.WriteLine($"\nNumber 2190912 is palindrome : {isPalindrome(2190912)}");
Console.WriteLine($"\nNumber 781087 is palindrome : {isPalindrome(781087)}\n\n");

int[] arr = new int[] { 3, 5, 3, -1, 5, 2, 7 };
int[] arr2 = new int[] { 3, -1, 2 };
foreach(int value in sortArray(arr, arr2))
{
    Console.Write(value + " ");
}
Console.WriteLine("\n");

Website website= new Website();
website.setData("Mcdonalds", "https://www.mcdonalds.com/ua/uk-ua.html",
    "McDonald's is restaurants in more than 100 countries...", "162.242.98.12");
website.Info();
website.Name = "My git";
website.Description = "My git repositories page";
website.URL = "https://github.com/What-I-pressed?tab=repositories";
website.IP = "167.128.22.1";
website.Info();
Console.WriteLine();

Magazine magazine= new Magazine();
magazine.setData("Visnyk", new DateTime(2000, 2, 3), "The main Ukrainian magazine",
    "0968678512", "bootuk.oof@gmail.com");
magazine.Info();
magazine.Name = "Vogue";
magazine.Info();

Shop shop = new Shop();
shop.Name = "My Shop";
shop.Address = "123 Sample Street";
shop.Description = "We sell products";
shop.ContactPhone = "+1234567890";
shop.Email = "info@myshop.com";
shop.Info();

void square(int length, char symbol)
{
    for(int i = 0; i < length; i++)
    {
        for(int j = 0; j < length; j++) {
            Console.Write(symbol + " ");
        }Console.WriteLine();
    }
}

bool isPalindrome(int number)
{
    string num = number.ToString();
    for(int i = 0, j = num.Length - 1; i < num.Length / 2; i++, j--)
    {
        if (num[i] != num[j]) return false;
    }
    return true;
}

int[] sortArray(int[] array, int[] prohibitedNums)
{
    return array.Where(value => !prohibitedNums.Contains(value)).ToArray();
}

class Website
{
    private string name;
    private string url;
    private string description;
    private string ip;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string URL
    {
        get { return url; }
        set { url = value; }
    }

    public string IP
    {
        get { return ip; }
        set { ip = value; }
    }

    public void setData(string name, string url, string description, string IP)
    {
        this.name = name;
        this.url = url;
        this.description = description;
        this.IP = IP;
    }

    public void Info()
    {
        Console.WriteLine($"Name : {name}\nurl : {url}\nDescription : {description}\nIP : {IP}\n");
    }
}

class Magazine
{
    private string name;
    private DateTime yearOfFoundation;
    private string description;
    private string phone;
    private string email;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public DateTime YearOfFoundation
    {
        get { return yearOfFoundation; }
        set { yearOfFoundation = value; }
    }

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public void setData(string name, DateTime yearOfFoundation, string description, string phone, string email)
    {
        this.name = name;
        this.yearOfFoundation = yearOfFoundation;
        this.description = description;
        this.phone = phone;
        this.email = email;
    }

    public void Info()
    {
        Console.WriteLine($"Name : {name}\nYear of foundation : {yearOfFoundation.Year}\n" +
            $"Description : {description}\nPhone : {phone}\nEmail : {email}\n");
    }
}

class Shop
{
    private string name;
    private string address;
    private string description;
    private string contactPhone;
    private string email;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string ContactPhone
    {
        get { return contactPhone; }
        set { contactPhone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public void Info()
    {
        Console.WriteLine("Назва магазину: " + name);
        Console.WriteLine("Адреса: " + address);
        Console.WriteLine("Опис профілю магазину: " + description);
        Console.WriteLine("Контактний телефон: " + contactPhone);
        Console.WriteLine("Email: " + email);
    }
}
