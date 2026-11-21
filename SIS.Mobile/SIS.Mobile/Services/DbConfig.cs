namespace SIS.Mobile.Services;

public static class DbConfig
{
   
    public static string Host => DeviceInfo.DeviceType == DeviceType.Virtual
        ? "10.0.2.2"
        : Preferences.Get("db_host", "192.168.1.100"); // real phone: your PC's LAN IP

    public static string ConnectionString =>
        $"Server={Host};Port=3306;Database=student_information_system;" +
        "User ID=sis_mobile;Password=sis_mobile_pw;" +
        "SslMode=None;AllowPublicKeyRetrieval=True;Connection Timeout=5;";
}