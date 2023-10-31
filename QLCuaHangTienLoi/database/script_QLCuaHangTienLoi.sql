CREATE DATABASE QLCuaHangTienLoi;
GO
USE QLCuaHangTienLoi;
GO
CREATE TABLE roles
(
    role_id   INT PRIMARY KEY IDENTITY,
    role_name NVARCHAR(255) NOT NULL
);
INSERT INTO roles(role_name)
VALUES (N'Quản lý'),
       (N'Khách hàng'),
       (N'Nhân viên');
GO
CREATE TABLE user_account
(
    user_id   INT PRIMARY KEY IDENTITY,
    username  VARCHAR(255)  NOT NULL,
    password  VARCHAR(255)  NOT NULL,
    full_name NVARCHAR(255) NULL,
    gender    NVARCHAR(50)  NULL,
    age       INT           NULL,
    address   NVARCHAR(500) NULL,
    phone     NVARCHAR(20)  NULL,
    role_id   INT           NULL,
    status    VARCHAR(100) DEFAULT 'ACTIVE',
    CONSTRAINT fk_user_role FOREIGN KEY (role_id) REFERENCES roles (role_id),
    CONSTRAINT ck_gender CHECK (gender IN ('Nam', N'Nữ')),
    CONSTRAINT ck_status_userAccount CHECK (status IN ('ACTIVE', 'INACTIVE'))
);
INSERT INTO user_account(username, password, role_id)
VALUES ('tung', '123321', 1);
GO
CREATE TABLE products
(
    product_id   INT PRIMARY KEY IDENTITY,
    product_name NVARCHAR(255)  NOT NULL,
    image        NVARCHAR(1000) NULL,
    price        FLOAT          NULL,
    stock        INT            NULL,
    status       VARCHAR(100) DEFAULT 'ACTIVE',
    CONSTRAINT ck_status_product CHECK (status IN ('ACTIVE', 'INACTIVE'))
);
GO
CREATE TABLE orders
(
    order_id    INT PRIMARY KEY IDENTITY,
    user_id     INT   NULL,
    buy_date    DATETIME     DEFAULT GETDATE(),
    total_price FLOAT NULL,
    status      VARCHAR(100) DEFAULT 'PENDING',
    CONSTRAINT ck_status_orders CHECK (status IN ('REJECTED', 'IN PROGRESS', 'PENDING', 'COMPLETED')),
	CONSTRAINT fk_orders_user FOREIGN KEY(user_id) REFERENCES user_account(user_id)
);

GO
CREATE TABLE order_item
(
    order_item_id    INT PRIMARY KEY IDENTITY,
    order_id         INT   NULL,
    product_id       INT   NULL,
    quantity         INT   NULL,
    total_price_item FLOAT NULL,
	CONSTRAINT fk_orderItem_order FOREIGN KEY(order_id) REFERENCES orders(order_id),
	CONSTRAINT fk_orderItem_produt FOREIGN KEY(product_id) REFERENCES products(product_id)
);