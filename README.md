# 🏠 Your NxtHome

> **Your Smart Flat Finder** — Making Renting Easy for Everyone

A desktop-based rental accommodation platform built with **C# .NET / WinForms** and **Microsoft SQL Server**, designed to connect tenants and property owners in Bangladesh without the hassle of door-to-door searching.

---

## 📖 About the Project

**Your NxtHome** is a C# WinForms desktop application that solves a major pain point in Bangladesh's rental market — especially for bachelors, job holders, and students who struggle to find accommodation due to landlord preferences and lack of a centralized listing platform.

The platform allows tenants to search and filter properties, book flats, chat with owners, make rent offers, and rate property owners — all from a single application.

---

## ✨ Features

| Feature | Available To |
|---|---|
| Browse & filter listings (Bachelor/Family, Restricted/Free) | Guest & Users |
| User registration & role-based login | All |
| Create & manage property listings | Registered Users |
| Booking system (Pending → Confirmed / Rejected) | Registered Users |
| Wishlist — save favorite properties | Registered Users |
| In-app messaging & rent offer making | Registered Users |
| Star ratings (1–5) with comments for owners | Users with confirmed bookings |
| Password reset via NID & contact verification | All |
| Admin panel — manage users, posts, bookings, messages | Admin |
| Developer panel — DB browser, SQL runner, activity logs, full stats | Developer |

---

## 🛠 Tech Stack

| Layer | Technology |
|---|---|
| Frontend / UI | Windows Forms (WinForms) |
| Backend | C# .NET |
| Database | Microsoft SQL Server (T-SQL) |
| Authentication | Custom username/password with NID verification |
| File Storage | Local file system (image path stored in DB) |
| IDE | Visual Studio |

---

## 🚀 Getting Started

### Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/) (or later) with **.NET Desktop Development** workload
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (2019 or later)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/YourNxtHome.git
   cd YourNxtHome
   ```

2. **Open the solution**
   - Open `YourNxtHome.sln` in Visual Studio

3. **Configure the database connection**
   - Locate the connection string in the project (typically in a `DBConnection.cs` or `App.config` file)
   - Update it to point to your SQL Server instance:
   ```
   Server=YOUR_SERVER_NAME;Database=YourNxtHomeDB;Integrated Security=True;
   ```

4. **Set up the database** (see [Database Setup](#database-setup) below)

5. **Build and run**
   - Press `Ctrl + F5` or click **Start** in Visual Studio

---

## 🗄 Database Setup

Run the following SQL scripts in SSMS to create the database and all required tables.

```sql
CREATE DATABASE YourNxtHomeDB;
USE YourNxtHomeDB;

-- Table 1: user_info
CREATE TABLE user_info (
    UserId       NVARCHAR(50)  NOT NULL PRIMARY KEY,
    Name         NVARCHAR(100) NOT NULL,
    Phone        NVARCHAR(20)  NOT NULL,
    Email        NVARCHAR(100) NOT NULL,
    NID          NVARCHAR(50)  NOT NULL,
    Address      NVARCHAR(255) NULL,
    Occupation   NVARCHAR(100) NULL,
    UserPassword NVARCHAR(255) NOT NULL,
    Role         VARCHAR(20)   NULL DEFAULT 'User',
    ImagePath    NVARCHAR(225) NULL
);

-- Table 2: Posts
CREATE TABLE Posts (
    PostId          INT IDENTITY(1,1) PRIMARY KEY,
    OwnerId         NVARCHAR(50)   NOT NULL,
    PostTitle       NVARCHAR(200)  NOT NULL,
    Location        NVARCHAR(200)  NOT NULL,
    Rent            INT            NOT NULL,
    Description     NVARCHAR(1000) NULL,
    TenantType      VARCHAR(20)    NULL,  -- 'Bachelor' or 'Family'
    RestrictionType VARCHAR(20)    NULL,  -- 'Restricted' or 'RestrictionLess'
    PostPhoto       VARBINARY(MAX) NULL,
    PostDate        DATETIME       DEFAULT GETDATE(),
    FOREIGN KEY (OwnerId) REFERENCES user_info(UserId)
);

-- Table 3: Bookings
CREATE TABLE Bookings (
    BookingId   INT IDENTITY(1,1) PRIMARY KEY,
    UserId      NVARCHAR(50) NOT NULL,
    PostId      INT          NOT NULL,
    BookingDate DATETIME     DEFAULT GETDATE(),
    Status      VARCHAR(20)  DEFAULT 'Pending',  -- 'Pending', 'Confirmed', 'Rejected'
    FOREIGN KEY (UserId) REFERENCES user_info(UserId),
    FOREIGN KEY (PostId) REFERENCES Posts(PostId)
);

-- Table 4: Wishlist
CREATE TABLE Wishlist (
    Id        INT IDENTITY(1,1) PRIMARY KEY,
    UserId    NVARCHAR(50) NOT NULL,
    PostId    INT          NOT NULL,
    AddedDate DATETIME     DEFAULT GETDATE(),
    FOREIGN KEY (UserId) REFERENCES user_info(UserId),
    FOREIGN KEY (PostId) REFERENCES Posts(PostId)
);

-- Table 5: Ratings
CREATE TABLE Ratings (
    Id        INT IDENTITY(1,1) PRIMARY KEY,
    UserId    NVARCHAR(50)  NOT NULL,  -- Tenant who rated
    OwnerId   NVARCHAR(50)  NOT NULL,  -- Owner being rated
    Rating    INT           CHECK (Rating BETWEEN 1 AND 5),
    Comment   NVARCHAR(500) NULL,
    RatedDate DATETIME      DEFAULT GETDATE(),
    FOREIGN KEY (UserId)  REFERENCES user_info(UserId),
    FOREIGN KEY (OwnerId) REFERENCES user_info(UserId)
);

-- Table 6: Messages
CREATE TABLE Messages (
    MessageId   INT IDENTITY(1,1) PRIMARY KEY,
    SenderId    NVARCHAR(50)   NOT NULL,
    ReceiverId  NVARCHAR(50)   NOT NULL,
    MessageText NVARCHAR(1000) NOT NULL,
    SentTime    DATETIME       DEFAULT GETDATE(),
    FOREIGN KEY (SenderId)   REFERENCES user_info(UserId),
    FOREIGN KEY (ReceiverId) REFERENCES user_info(UserId)
);
```

### Seed a Developer Account

To access the Developer panel, insert a developer user manually:

```sql
INSERT INTO user_info (UserId, Name, Phone, Email, NID, UserPassword, Role)
VALUES ('Developer', 'Developer', '01700000000', 'dev@nxthome.com', '0000000000', 'yourpassword', 'Developer');
```

---

## 👥 User Roles

| Role | Access Level |
|---|---|
| **Guest** | Browse & filter listings only (view-only, no booking/chat/rating) |
| **User** | Full tenant & owner features — post, book, chat, wishlist, rate |
| **Admin** | Manage all users, posts, bookings, and messages; platform overview |
| **Developer** | Full DB browser, SQL runner, activity logs, role management, full stats |

> ⚠️ Only a **Developer** can assign or change user roles. Admins cannot modify roles.

---

## 📁 Project Structure

```
YourNxtHome/
│
├── Forms/
│   ├── HomePage.cs
│   ├── SignIn.cs
│   ├── SignUp.cs
│   ├── ForgotPassword.cs
│   ├── UserDashboard.cs
│   ├── ViewPosts.cs
│   ├── CreatePost.cs
│   ├── PostDetails.cs
│   ├── Wishlist.cs
│   ├── Chat.cs
│   ├── BookingRequests.cs
│   ├── RateOwner.cs
│   ├── AdminPanel/
│   │   ├── AdminDashboard.cs
│   │   ├── AdminPosts.cs
│   │   ├── AdminUsers.cs
│   │   ├── AdminBookings.cs
│   │   └── AdminMessages.cs
│   └── DeveloperPanel/
│       ├── DevDashboard.cs
│       ├── DBBrowser.cs
│       ├── SQLRunner.cs
│       ├── FullStats.cs
│       ├── ActivityLogs.cs
│       └── DevUserInfo.cs
│
├── Database/
│   └── DBConnection.cs
│
├── Models/          (if applicable)
├── Assets/          (icons, images)
└── YourNxtHome.sln
```

---

## 🔮 Future Improvements

- [ ] **Property availability status** — auto-mark as Booked once confirmed
- [ ] **Multiple image upload** per property post
- [ ] **Live map / Google Maps integration** for property location
- [ ] **Pet policy & parking information** fields
- [ ] **User verification system** post-registration
- [ ] **Audio/Video calling** & notification system
- [ ] **Scam alert & reporting** system
- [ ] **Mobile app** (Android/iOS)
- [ ] **Online payment integration** for booking & advance rent

---

## 👨‍💻 Team

| Name | Student ID | Email | Role |
|---|---|---|---|
| **Md. Naiem Uddin** | 24-59184-3 | 24-59184-3@student.aiub.edu | 👑 **Project Leader** |
| Abu Bakar Mohammad Abdullah | 24-59920-3 | 24-59920-3@student.aiub.edu | Member |
| Tajkiya Islam | 24-59163-3 | 24-59163-3@student.aiub.edu | Member |
| Kasfia Suzana | 24-59864-3 | 24-59864-3@student.aiub.edu | Member |

**Supervised by:** Dr. Md. Iftekharul Mobin  
**Course:** CSC2210 — Object Oriented Programming 2  
**Institution:** American International University–Bangladesh (AIUB)  
**Semester:** Spring 25-26

---

## 📬 Contact

- 📧 Email: yournxthome@gmail.com
- 📞 Phone: 09608-059184
- 📍 Location: Dhaka, Bangladesh

---

> *"AT YOUR NXTHOME, WE AIM TO MAKE THE RENTING PROCESS SIMPLE, EFFICIENT, AND ACCESSIBLE FOR EVERYONE."*
