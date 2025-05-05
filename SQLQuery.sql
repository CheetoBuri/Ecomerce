-- Create database
CREATE DATABASE EComerceDB;
GO

-- Use the database
USE EComerceDB;
GO

-- Create Item table
CREATE TABLE Item (
    ItemID INT PRIMARY KEY,
    ItemName NVARCHAR(100),
    Size NVARCHAR(50),
    Price DECIMAL(10,2)
);

-- Create Agent table
CREATE TABLE Agent (
    AgentID INT PRIMARY KEY,
    AgentName NVARCHAR(100),
    Address NVARCHAR(200),
    Phone NVARCHAR(20)
);

-- Create Order table
CREATE TABLE [Order] (
    OrderID INT PRIMARY KEY,
    OrderDate DATE,
    AgentID INT FOREIGN KEY REFERENCES Agent(AgentID),
    TotalAmount DECIMAL(10,2)
);

-- Create OrderDetail table
CREATE TABLE OrderDetail (
    ID INT PRIMARY KEY,
    OrderID INT FOREIGN KEY REFERENCES [Order](OrderID),
    ItemID INT FOREIGN KEY REFERENCES Item(ItemID),
    Quantity INT,
    UnitAmount DECIMAL(10,2)
);

-- Create Users table
CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    UserName NVARCHAR(50),
    Email NVARCHAR(100),
    Password NVARCHAR(100)
);

-- Insert sample data into Item
INSERT INTO Item VALUES
(1, 'Laptop', '15 inch', 800),
(2, 'Mouse', 'Standard', 20),
(3, 'Keyboard', 'Full Size', 45),
(4, 'Monitor', '24 inch', 150),
(5, 'Printer', 'Laser', 200),
(6, 'Tablet', '10 inch', 300),
(7, 'Smartphone', '6 inch', 700),
(8, 'Webcam', 'HD', 60),
(9, 'Speaker', 'Bluetooth', 120),
(10, 'Headphones', 'Over-Ear', 80),
(11, 'Charger', 'USB-C', 25),
(12, 'Router', 'WiFi 6', 180),
(13, 'SSD', '512 GB', 130),
(14, 'Graphics Card', '8GB', 500),
(15, 'External HDD', '1TB', 100),
(16, 'Microphone', 'USB', 90),
(17, 'Projector', 'Full HD', 600),
(18, 'Power Bank', '10000mAh', 40);

-- Insert sample data into Agent
INSERT INTO Agent VALUES
(1, 'John Smith', '123 Main St', '123-456-7890'),
(2, 'Alice Johnson', '456 Oak Ave', '234-567-8901'),
(3, 'Bob Williams', '789 Pine Rd', '345-678-9012'),
(4, 'Carol Brown', '101 Maple Blvd', '456-789-0123'),
(5, 'David Davis', '202 Elm St', '567-890-1234'),
(6, 'Eve Miller', '303 Cedar Ln', '678-901-2345'),
(7, 'Frank Wilson', '404 Spruce Ct', '789-012-3456'),
(8, 'Grace Taylor', '505 Birch Pl', '890-123-4567'),
(9, 'Hank Anderson', '606 Cherry Way', '901-234-5678'),
(10, 'Ivy Thomas', '707 Walnut Dr', '012-345-6789');

-- Insert sample data into Order
INSERT INTO [Order] VALUES
(1, '2025-05-01', 1, 500),
(2, '2025-05-02', 2, 150),
(3, '2025-05-03', 3, 250),
(4, '2025-05-04', 4, 700),
(5, '2025-05-05', 5, 400),
(6, '2025-05-06', 6, 350),
(7, '2025-05-07', 7, 800),
(8, '2025-05-08', 8, 120),
(9, '2025-05-09', 9, 230),
(10, '2025-05-10', 10, 600),
(11, '2025-05-11', 1, 420),
(12, '2025-05-12', 2, 330),
(13, '2025-05-13', 3, 150),
(14, '2025-05-14', 4, 500),
(15, '2025-05-15', 5, 750);

-- Insert sample data into OrderDetail
INSERT INTO OrderDetail VALUES
(1, 1, 1, 1, 800),
(2, 1, 2, 2, 20),
(3, 2, 3, 1, 45),
(4, 2, 4, 1, 150),
(5, 3, 5, 1, 200),
(6, 3, 6, 1, 300),
(7, 4, 7, 1, 700),
(8, 4, 8, 2, 60),
(9, 5, 9, 1, 120),
(10, 5, 10, 1, 80),
(11, 6, 11, 2, 25),
(12, 6, 12, 1, 180),
(13, 7, 13, 1, 130),
(14, 7, 14, 1, 500),
(15, 8, 15, 1, 100),
(16, 8, 16, 1, 90),
(17, 9, 17, 1, 600),
(18, 9, 18, 2, 40),
(19, 10, 1, 1, 800),
(20, 10, 2, 3, 20),
(21, 11, 3, 1, 45),
(22, 11, 4, 1, 150),
(23, 12, 5, 1, 200),
(24, 12, 6, 1, 300),
(25, 13, 7, 1, 700),
(26, 13, 8, 2, 60),
(27, 14, 9, 1, 120),
(28, 14, 10, 1, 80),
(29, 15, 11, 2, 25),
(30, 15, 12, 1, 180);

-- Insert sample data into Users
INSERT INTO Users VALUES
(1, 'admin', 'admin@example.com', 'admin123'),
(2, 'johndoe', 'john@example.com', 'pass123'),
(3, 'alice', 'alice@example.com', 'alicepass'),
(4, 'bob', 'bob@example.com', 'bobpass'),
(5, 'carol', 'carol@example.com', 'carolpass'),
(6, 'david', 'david@example.com', 'davidpass'),
(7, 'eve', 'eve@example.com', 'evepass'),
(8, 'frank', 'frank@example.com', 'frankpass'),
(9, 'grace', 'grace@example.com', 'gracepass'),
(10, 'hank', 'hank@example.com', 'hankpass'),
(11, 'ivy', 'ivy@example.com', 'ivypass'),
(12, 'jack', 'jack@example.com', 'jackpass'),
(13, 'karen', 'karen@example.com', 'karenpass'),
(14, 'leo', 'leo@example.com', 'leopass'),
(15, 'mia', 'mia@example.com', 'miapass');
