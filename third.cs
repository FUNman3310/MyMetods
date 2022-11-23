



static int LastIndexOf(string name,char value)
{
    int index = name.Length-1;

    for (int i = name.Length - 1; i >= 0; i--)
    {
        if (value==name[i])
        {
            return index;
        }
        index--;
        
    }
    return -1;
} 

static bool Contains(string name, string find)
{
    int count = 0;
    for (int i = 0; i < name.Length; i++)
    {
        count = 0;
        for (int j = 0; j < find.Length; j++)
        {
            if (name[i+count]==find[j])
            {
                count++;
            }
            else
            {
                break;
            }
        }
        if (count == find.Length)
        {
            break;
        }
    }
    if (count == find.Length)
    {
        return true;
    }
    else
    {
        return false;
    }
}


static string Substring(string name ,int start,int count)
{
    string NewName = "";
    for (int i = start; i < start+(count); i++)
    {
        NewName+=name[i];
    }
    return NewName;
}

static string Trim(string name)
{
    int count = 0;
    int start = 0;
    int end = name.Length-1;
    Char[] NewName = new Char[0];

    if(name[0]==' ')
    {
        for (int i = 0; i < name.Length; i++)
        {
            start++;

            if (name[i] != ' ')
            {
                break;
            }
        }
    }
    if (name[name.Length-1]==' ')
    {
        for (int i = name.Length - 1; i >= 0; i--)
        {
            if (name[i] != ' ')
            {
                break;
            }

            end--;
        }
    }
    
    for (int i = name[start]; i <= name[end]; i++)
    {
        Array.Resize(ref NewName, NewName.Length + 1);
        NewName[0+count]=name[i];
        // burda basha dusmirem nece arrayin sayzi deyisim
       count++;
    }

    return NewName.ToString(); 
}

static string Replace(string name,char replace, char value)
{
    char[] CharArr = new char[name.Length];

    for (int i = 0; i < name.Length; i++)
    {
        CharArr[i] = name[i];
    }
    for (int i = 0; i < CharArr.Length; i++)
    {
        if (replace==CharArr[i])
        {
            CharArr[i]=value;
        }
    }
    
    return CharArr.ToString();
}