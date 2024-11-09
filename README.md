# ขั้นตอนในการใช้งาน
### 1. ติดตั้งเครื่องมือที่จําเป็น

-   [Visual Studio 2022](https://visualstudio.microsoft.com/downloads)  หรือ  [Visual Studio Code](https://code.visualstudio.com/)
-   [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQL Server -สามารถใช้ฐานข้อมูลอื่นได้ แต่ตรวจสอบให้แน่ใจว่ามีConnectionStringsที่ถูกต้อง

### 2. กําหนดConnectionStrings

-   ทําการเปลี่ยนแปลงConnectionStringsต่อในแฟ้ม`AppSettings.json`

### 3. อัพเดตข้อมูล

#### ใช้ Visual Studio:

1.  ไปที่  **Tools**  =>  **NuGet Package Manager**  =>  **Package Manager Console**
2.  เรียกใช้คําสั่ง: .`update-database`

#### ใช้ Visual Studio Code:
1.  เปิดเทอร์มินัล
2.  เรียกใช้คําสั่งต่อไปนี้: .`dotnet ef database update`
