-- 1. user_info Table
use user_info
select * from user_info
CREATE TABLE user_info (
    UserId        NVARCHAR(50)  NOT NULL PRIMARY KEY,
    Name          NVARCHAR(100) NOT NULL,
    Phone         NVARCHAR(20)  NOT NULL,
    Email         NVARCHAR(100) NOT NULL,
    NID           NVARCHAR(50)  NOT NULL,
    Address       NVARCHAR(255) NULL,
    Occupation    NVARCHAR(100) NULL,
    UserPassword  NVARCHAR(255) NOT NULL,
    Role          VARCHAR(20)   NULL,
    ImagePath     NVARCHAR(225) NULL
);

-- 2. Posts Table
use Posts
CREATE TABLE Posts (
    PostId      INT IDENTITY(1,1) PRIMARY KEY,
    OwnerId     NVARCHAR(50) NOT NULL,
    PostTitle   NVARCHAR(200) NOT NULL,
    Location    NVARCHAR(200) NOT NULL,
    Rent        INT NOT NULL,
    Description NVARCHAR(1000),
    PostPhoto   VARBINARY(MAX),
    PostDate    DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (OwnerId) REFERENCES user_info(UserId)
);
select * from Posts

-- 3. Bookings Table
CREATE TABLE Bookings (
    BookingId   INT IDENTITY(1,1) PRIMARY KEY,
    UserId      NVARCHAR(50) NOT NULL,
    PostId      INT NOT NULL,
    BookingDate DATETIME DEFAULT GETDATE(),
    Status      VARCHAR(20) DEFAULT 'Pending',
    FOREIGN KEY (UserId) REFERENCES user_info(UserId),
    FOREIGN KEY (PostId) REFERENCES Posts(PostId)
);
select * from Wishlist

-- 4. Wishlist Table
CREATE TABLE Wishlist (
    Id          INT IDENTITY(1,1) PRIMARY KEY,
    UserId      NVARCHAR(50) NOT NULL,
    PostId      INT NOT NULL,
    AddedDate   DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserId) REFERENCES user_info(UserId),
    FOREIGN KEY (PostId) REFERENCES Posts(PostId)
);

-- 5. Ratings Table
CREATE TABLE Ratings (
    Id          INT IDENTITY(1,1) PRIMARY KEY,
    UserId      NVARCHAR(50) NOT NULL,
    OwnerId     NVARCHAR(50) NOT NULL,
    Rating      INT CHECK (Rating BETWEEN 1 AND 5),
    Comment     NVARCHAR(500),
    RatedDate   DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserId) REFERENCES user_info(UserId),
    FOREIGN KEY (OwnerId) REFERENCES user_info(UserId)
);

-- 6. Messages Table
CREATE TABLE Messages (
    MessageId   INT IDENTITY(1,1) PRIMARY KEY,
    SenderId    NVARCHAR(50) NOT NULL,
    ReceiverId  NVARCHAR(50) NOT NULL,
    MessageText NVARCHAR(1000) NOT NULL,
    SentTime    DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (SenderId) REFERENCES user_info(UserId),
    FOREIGN KEY (ReceiverId) REFERENCES user_info(UserId)
);