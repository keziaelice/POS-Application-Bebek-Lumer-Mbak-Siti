CREATE DATABASE IF NOT EXISTS SeCu2;
USE SeCu2;

DROP TABLE IF EXISTS Customer;
CREATE TABLE Customer (
    IDcustomer VARCHAR(6) PRIMARY KEY,
    nama_customer VARCHAR(30) NOT NULL,
    status_del CHAR(1)
);

INSERT INTO Customer values
('S00001', 'Siti Nurbaya', 0),
('P00001', 'Patrick Chandra', 0),
('S00002', 'Steve Liendo', 0)
;

DROP TABLE IF EXISTS Menu;
CREATE TABLE Menu (
    IDmenu VARCHAR(5) PRIMARY KEY,
    nama_menu VARCHAR(25),
    harga INT,
    kategori CHAR(1) NOT NULL,
    IDbahan VARCHAR(5),
    gambar VARCHAR(25),
    status_del CHAR(1),
    CONSTRAINT kategori CHECK (kategori = 'F' OR kategori = 'B')
);

INSERT INTO Menu values
('A0001', 'Ayam Goreng Paha', 23000, 'F', 'ΒΑ002', 'K_picture_menu_A0001.jpg', 0),
('A0002', 'Ayam Goreng Dada', 23000, 'F', 'ΒΑ001', 'K_picture_menu_A0002.jpg', 0),
('B0001', 'Bebek Goreng Paha', 25000, 'F', 'ΒB002', 'K_picture_menu_B0001.jpg', 0),
('B0002', 'Bebek Goreng Dada', 25000, 'F', 'ΒB001', 'K_picture_menu_B0002.jpg', 0),
('B0003', 'Bebek Goreng Kepala', 25000, 'F', 'BB003', 'K_picture_menu_B0003.jpg', 0),
('B0004', 'Bebek Lumer Paha', 25000, 'F', 'ΒB002', 'K_picture_menu_B0004.jpg', 0),
('B0005', 'Bebek Lumer Dada', 25000, 'F', 'ΒB001', 'K_picture_menu_B0005.jpg', 0),
('T0001', 'Tempe Goreng', 2000, 'F', 'ΒT001', 'K_picture_menu_T0001.jpg', 0),
('T0002', 'Tahu Goreng', 2000, 'F', 'ΒT002', 'K_picture_menu_T0002.jpg', 0),
('E0001', 'Es Nutri Sari Jeruk', 4000, 'B', 'BN001', 'K_picture_menu_E0001.jpg', 0),
('E0002', 'Es Nutri Sari Lychee', 4000, 'B', 'BN002', 'K_picture_menu_E0002.jpg', 0),
('E0003', 'Es Nutri Sari Lemon', 4000, 'B', 'BN003', 'K_picture_menu_E0003.jpg', 0),
('E0004', 'Es Nutri Sari Apel', 4000, 'B', 'BN004', 'K_picture_menu_E0004.jpg', 0),
('E0005', 'Es Tea Jus', 3000, 'B', 'BT003', 'K_picture_menu_E0005.jpg', 0)
;

drop table if exists Pesan;
CREATE TABLE Pesan (
  IDorder varchar(11) PRIMARY KEY,
  IDmenu varchar(5) not null,
  tglOrder date,
  jumlah_pes int,
  IDuser varchar(4) not null,
  IDcustomer varchar(6) not null,
  done varchar(20) default 'ON PROGRESS',
  status_del char(1)
);

Insert into Pesan values
('P0612230001', 'A0001', '2023-12-06', 1, 'U001', 'S00001','ON PROGRESS', 0)
;

drop table if exists Done;
CREATE TABLE Done (
  IDorder varchar(11) not null,
  IDmenu varchar(5) not null,
  tglOrder date,
  jumlah_pes int,
  IDuser varchar(4) not null,
  IDcustomer varchar(6) not null,
  status_del char(1)
);

Insert into Done values
('P2410230001', 'A0001', '2023-10-24', 1, 'U001', 'S00001', 0),
('P2410230002', 'A0002', '2023-10-24', 2, 'U001', 'S00001', 0),
('P2410230003', 'B0002', '2023-10-24', 1, 'U003', 'S00002', 0),
('P2410230004', 'B0001', '2023-10-24', 1, 'U003', 'S00002', 0),
('P2410230005', 'B0003', '2023-10-24', 1, 'U001', 'P00001', 0),
('P2410230006', 'E0001', '2023-10-24', 1, 'U001', 'P00001', 0),
('P2410230007', 'E0002', '2023-10-24', 1, 'U001', 'P00001', 0)
;

DROP TABLE IF EXISTS Invoice;
CREATE TABLE Invoice (
  IDpemesanan varchar(10) PRIMARY KEY,
  tgl_cetak datetime,
  total_cetak int,
  jumlah_harga int,
  IDorder varchar(11),
  status_del char(1),
  IDuser varchar(4) not null
);

INSERT INTO Invoice values
('2410230001', '2023-10-24 14:30:42', 1, 23000, 'P2410230001', 0, 'U002'),
('2410230002', '2023-10-24 15:45:12', 1, 46000, 'P2410230002', 0, 'U002'), 
('2410230003', '2023-10-24 16:00:07', 1, 25000, 'P2410230003', 0, 'U003'), 
('2410230004', '2023-10-24 16:05:10', 1, 50000, 'P2410230004', 0, 'U003'),
('2410230005', '2023-10-24 16:26:43', 1, 23000, 'P2410230005', 0, 'U001'),
('2410230006', '2023-10-24 17:11:26', 1, 46000, 'P2410230006', 0, 'U001'),
('2410230007', '2023-10-24 17:52:13', 1, 75000, 'P2410230007', 0, 'U001')
;

DROP TABLE IF EXISTS Bahan;
CREATE TABLE Bahan (
  IDbahan varchar(5) PRIMARY KEY,
  nama_bahan varchar(25),
  stok int,
  satuan varchar(10),
  harga_bahan int,
  status_del char(1)
);

INSERT INTO Bahan values
('ΒΑ001', 'Ayam Dada', 25, 'potong', 10000, 0),
('ΒΑ002', 'Ayam Paha', 25, 'potong', 10000, 0),
('BB001', 'Bebek Dada', 25, 'potong', 15000, 0),
('BB002', 'Bebek Paha', 25, 'potong', 18000, 0),
('BB003', 'Bebek Kepala', 25, 'potong', 13000, 0),
('BB004', 'Beras', 5, 'karung', 69000, 0),
('BC001', 'Cabai Hijau', 2000, 'gr', 70, 0),
('BC002', 'Cabai Merah', 2000, 'gr', 70, 0),
('BT001', 'Tempe', 30, 'potong', 3000, 0),
('BT002', 'Tahu', 30, 'potong', 2000, 0),
('BΝ001', 'Nutri Sari Jeruk', 50, 'pcs', 4000, 0),
('BN002', 'Nutri Sari Lychee', 50, 'pcs', 4000, 0),
('BN003', 'Nutri Sari Lemon', 50, 'pcs', 4000, 0),
('BN004', 'Nutri Sari Apel', 50, 'pcs', 4000, 0),
('BT003', 'Tea Jus', 50, 'pcs', 3000, 0);

DROP TABLE IF EXISTS StrukBeli;
CREATE TABLE StrukBeli (
  IDbeli varchar(6) PRIMARY KEY,
  tgl_pembelian date,
  jumlah_bahan int,
  harga_satuan int,
  total int,
  IDbahan varchar(5) not null,
  status_del char(1)
);

INSERT INTO StrukBeli values
('B00001', '2022-10-29', 25, 10000, 250000, 'BB001', 0),
('B00002', '2023-10-24', 25, 8000, 200000, 'BA001', 0),
('B00003', '2023-11-05', 1, 51000, 51000, 'BC001', 0)
;

DROP TABLE IF EXISTS Pembukuan;
CREATE TABLE Pembukuan (
  IDTransaksi varchar(11) PRIMARY KEY,
  IDbeli varchar(6),
  IDpemesanan varchar(10),
  keterangan varchar(30) not null,
  status_del char(1)
);

INSERT INTO Pembukuan values
('T2410230001', 'B00002', null, 'Pengeluaran', 0),
('T2410230002', null, '2410230001', 'Pemasukan', 0),
('T2410230003', null, '2410230002', 'Pemasukan', 0), 
('T2410230004', null, '2410230003', 'Pemasukan', 0)
;

DROP TABLE IF EXISTS Userr;
CREATE TABLE Userr (
  IDuser varchar(4) PRIMARY KEY,
  pass_user varchar(15) not null,
  nama_user varchar(30) not null,
  status_del char(1),
  IDjabatan varchar(4) not null
);

INSERT INTO Userr values
('U001', 'adminadmin', 'Dito Surya', 0, 'W001'),
('U002', 'adminadmin', 'Fajar Nugraha', 0, 'W001'),
('U003', 'adminadmin', 'Gita Maharani', 0, 'K001')
;

DROP TABLE IF EXISTS Staff;
CREATE TABLE Staff (
  IDstaff varchar(4) PRIMARY KEY,
  nama_staff varchar(30),
  status_del char(1),
  IDjabatan varchar(4) not null
);

INSERT INTO Staff values
('S001', 'Anisa Wulandari', 0, 'C001'),
('S002', 'Bima Pratama', 0, 'C001'),
('S003', 'Cindy Putri', 0, 'C001')
;

DROP TABLE IF EXISTS Jabatan;
CREATE TABLE Jabatan (
  IDjabatan varchar(5) PRIMARY KEY,
  nama_jabatan varchar(20) not null,
  status_del char(1)
);

INSERT INTO Jabatan values
('P001', 'Pemilik', 0),
('W001', 'Waiter', 0),
('C001', 'Chef', 0),
('K001', 'Kasir', 0)
;

DROP TABLE IF EXISTS StockOpname;
CREATE TABLE StockOpname (
IDstock varchar(6) PRIMARY KEY,
tgl_stock date,
stock_awal int,
stock_realita int,
jumlah_perbedaan int,
keterangan varchar(30) not null,
status_del char(1),
IDbahan varchar(5) not null,
IDuser varchar(4) not null
);

INSERT INTO StockOpname values
('S00001', '2023-10-24', 30, 32, 2, 'Rusak dan tidak fresh', 0, 'BA001', 'U001'),
('S00002', '2023-10-24', 25, 24, 1, 'Waiter lupa mengurangi stock', 0, 'BB001', 'U001'),
('S00003', '2023-10-24', 43, 44, 1, 'Customer tidak jadi memesan', 0, 'BC001', 'U002')
;

-- VIEW
-- 1. View untuk menampilkan daftar menu makanan
DROP VIEW IF EXISTS vMenuMakanan;
CREATE VIEW vMenuMakanan AS
	SELECT m.IDmenu AS 'ID Menu', m.nama_menu AS 'Nama Menu', m.harga AS 'Harga', m.gambar AS 'Gambar'
    FROM menu m
    WHERE m.kategori = 'F'
    ORDER BY 1;
SELECT * FROM vMenuMakanan;

-- 2. View untuk menampilkan daftar menu minuman
DROP VIEW IF EXISTS vMenuMinuman;
CREATE VIEW vMenuMinuman AS
	SELECT m.IDmenu AS 'ID Menu', m.nama_menu AS 'Nama Menu', m.harga AS 'Harga', m.gambar AS 'Gambar'
    FROM menu m
    WHERE m.kategori = 'B'
    ORDER BY 1;
SELECT * FROM vMenuMinuman;

-- PROCEDURE
-- 1. Procedure untuk menampilkan detail pesanan customer dalam satu invoice
DELIMITER //
DROP PROCEDURE IF EXISTS pDetailPesanan;
CREATE PROCEDURE pDetailPesanan(IN IDcustomer varchar(11))
BEGIN
    SELECT
		p.IDorder,
        p.tglOrder,
        m.nama_menu,
        p.jumlah_pes,
        m.harga * p.jumlah_pes AS total_harga,
        c.nama_customer
    FROM Pesan p
    JOIN Menu m ON p.IDmenu = m.IDmenu
    JOIN Customer c ON p.IDcustomer = c.IDcustomer
    WHERE p.IDcustomer = IDcustomer;
END //
DELIMITER ;
call pDetailPesanan('S00001');

-- 2. Procedure untuk menampilkan status pesanan customer
DELIMITER //
DROP PROCEDURE IF EXISTS pShowOrderStatus;
CREATE PROCEDURE pShowOrderStatus(IN customerID VARCHAR(6))
BEGIN
  SELECT
    P.IDorder,
    P.tglOrder,
    M.nama_menu,
    P.jumlah_pes,
    P.done
  FROM
    Pesan P
    JOIN Menu M ON P.IDmenu = M.IDmenu
  WHERE
    P.IDcustomer = customerID;
END //
DELIMITER ;
call pShowOrderStatus('S00001');

-- FUNCTION
-- 1. Function untuk membuat IDcustomer secara otomatis
DELIMITER $$
DROP FUNCTION IF EXISTS fAutoGenIDcustomer;
CREATE FUNCTION fAutoGenIDcustomer(nama_customer VARCHAR(30))
RETURNS VARCHAR(6) DETERMINISTIC
BEGIN
	DECLARE newID VARCHAR(6);
	DECLARE jumlah VARCHAR(5);
    SET newID = SUBSTRING(nama_customer, 1, 1);
    SET jumlah = (SELECT LPAD((COUNT(c.IDcustomer) + 1), 5, '0')
				 FROM customer c
				 WHERE IDcustomer LIKE CONCAT(newID, '%'));
	SET newID = CONCAT(newID, jumlah);
    RETURN newID;
END $$
DELIMITER ;
SELECT fAutoGenIDcustomer('Patrick Steven');

-- 2. Function untuk membuat IDOrder secara otomatis
DELIMITER $$
DROP FUNCTION IF EXISTS fAutoGenIDOrder;
CREATE FUNCTION fAutoGenIDOrder()
RETURNS VARCHAR(11) DETERMINISTIC
BEGIN
	DECLARE newID VARCHAR(11);
	DECLARE jumlah VARCHAR(4);
    SET newID = CONCAT('P', DATE_fORMAT(CURDATE(), '%d%m%y'));
    SET jumlah = (SELECT LPAD((COUNT(p.IDorder) + 1), 4, '0')
				 FROM pesan p
				 WHERE IDorder LIKE CONCAT(newID, '%'));
	SET newID = CONCAT(newID, jumlah);
    RETURN newID;
END $$
DELIMITER ;
SELECT fAutoGenIDOrder();

-- 3. Function untuk membuat IDtransaksi secara otomatis
DELIMITER $$
DROP FUNCTION IF EXISTS fAutoGenIDTransaksi;
CREATE FUNCTION fAutoGenIDTransaksi()
RETURNS VARCHAR(11) DETERMINISTIC
BEGIN
 DECLARE newID VARCHAR(11);
 DECLARE jumlah VARCHAR(4);
    SET newID = CONCAT('T', DATE_fORMAT(CURDATE(), '%d%m%y'));
    SET jumlah = (SELECT LPAD((COUNT(p.IDTransaksi) + 1), 4, '0')
     FROM pembukuan p
     WHERE IDTransaksi LIKE CONCAT(newID, '%'));
 SET newID = CONCAT(newID, jumlah);
    RETURN newID;
END $$
DELIMITER ;
SELECT fAutoGenIDTransaksi();

-- 4. Function untuk membuat IDpemesanan secara otomatis
DELIMITER $$
DROP FUNCTION IF EXISTS fAutoGenIDpemesanan;
CREATE FUNCTION fAutoGenIDpemesanan()
RETURNS VARCHAR(10) DETERMINISTIC
BEGIN
 DECLARE newID VARCHAR(10);
 DECLARE jumlah VARCHAR(4);
    SET newID = DATE_fORMAT(CURDATE(), '%d%m%y');
    SET jumlah = (SELECT LPAD((COUNT(i.IDpemesanan) + 1), 4, '0')
     FROM invoice i
     WHERE IDpemesanan LIKE CONCAT(newID, '%'));
 SET newID = CONCAT(newID, jumlah);
    RETURN newID;
END $$
DELIMITER ;
SELECT fAutoGenIDpemesanan();

-- 5. Function untuk membuat IDstock secara otomatis
DELIMITER $$
DROP FUNCTION IF EXISTS fAutoGenIDstock;
CREATE FUNCTION fAutoGenIDstock()
RETURNS VARCHAR(6) DETERMINISTIC
BEGIN
 DECLARE newID VARCHAR(6);
 DECLARE jumlah VARCHAR(5);
    SET newID = 'S';
    SET jumlah = (SELECT LPAD((COUNT(s.IDstock) + 1), 5, '0')
     FROM stockopname s
     WHERE IDstock LIKE CONCAT(newID, '%'));
 SET newID = CONCAT(newID, jumlah);
    RETURN newID;
END $$
DELIMITER ;
SELECT fAutoGenIDstock();

-- 6. Function untuk membuat IDbeli secara otomatis
DELIMITER $$
DROP FUNCTION IF EXISTS fAutoGenIDbeli;
CREATE FUNCTION fAutoGenIDbeli()
RETURNS VARCHAR(6) DETERMINISTIC
BEGIN
 DECLARE newID VARCHAR(6);
 DECLARE jumlah VARCHAR(5);
    SET newID = 'B';
    SET jumlah = (SELECT LPAD((COUNT(s.IDbeli) + 1), 5, '0')
     FROM strukbeli s
     WHERE IDbeli LIKE CONCAT(newID, '%'));
 SET newID = CONCAT(newID, jumlah);
    RETURN newID;
END $$
DELIMITER ;
SELECT fAutoGenIDbeli();

-- 7. Function untuk mengupdate stok dalam tabel bahan
drop function if exists fUpdateStok;
delimiter $$
create function fUpdateStok(jumlah int, ID varchar(5))
returns varchar(300) deterministic
BEGIN
	declare newstok int;
	set newstok = (select b.stok + jumlah
	from bahan b
    where IDbahan = ID);
    
    return newstok;
END $$
delimiter ;
SELECT fUpdateStok('5', 'BB004');

-- TRIGGER
-- 1. Trigger untuk memanggil function pembuatan IDcustomer
drop trigger if exists tAutoGenIDCustomer;
delimiter $$
create trigger tAutoGenIDCustomer
before insert on customer
for each row
BEGIN
	set new.IDcustomer = fAutoGenIDCustomer(new.nama_customer);
END $$
delimiter ;

insert into customer values(1, "Indra Maryati", 0);
select * from customer order by 1 desc;

-- 2. Trigger untuk memanggil function pembuatan IDOrder
drop trigger if exists tAutoGenIDOrder;
delimiter $$
create trigger tAutoGenIDOrder
before insert on pesan
for each row
BEGIN
	set new.IDorder = fAutoGenIDOrder();
END $$
delimiter ;

Insert into Pesan values
(1, 'B0002', CURDATE(), 2, 'U001', 'S00001','ON PROGRESS', 0)
;
select * from Pesan;

-- 3. Trigger untuk memanggil function pembuatan IDTransaksi
drop trigger if exists tAutoGenIDTransaksi;
delimiter $$
create trigger tAutoGenIDTransaksi
before insert on Pembukuan
for each row
BEGIN
	set new.IDTransaksi = fAutoGenIDTransaksi();
END $$
delimiter ;

INSERT INTO Pembukuan values
(1, 'B00002', null, 'Pengeluaran', 0),
(1, null, '1912230002', 'Pemasukan', 0);

select * from Pembukuan;

-- 4. trigger untuk memanggil function pembuatan IDPemesanan
drop trigger if exists tAutoGenIDpemesanan;
delimiter $$
create trigger tAutoGenIDpemesanan
before insert on invoice
for each row
BEGIN
	set new.IDpemesanan = fAutoGenIDpemesanan();
END $$
delimiter ;

INSERT INTO Invoice values
(1, curdate(), 1, 50000, 'P1912230001', 0, 'U001');
select * from Invoice;

-- 5. Trigger untuk memanggil function pembuatan IDstock
drop trigger if exists tAutoGenIDStock;
delimiter $$
create trigger tAutoGenIDStock
before insert on stockopname
for each row
BEGIN
	set new.IDstock = fAutoGenIDstock();
END $$
delimiter ;

INSERT INTO StockOpname values
(1, '2023-12-19', 25, 22, 3, 'Rusak dan tidak fresh', 0, 'BA002', 'U001');
select * from StockOpname;

-- 6. Trigger untuk memanggil function pembuatan IDbeli
drop trigger if exists tAutoGenIDbeli;
delimiter $$
create trigger tAutoGenIDbeli
before insert on strukbeli
for each row
BEGIN
	set new.IDbeli = fAutoGenIDbeli();
END $$
delimiter ;

INSERT INTO StrukBeli values
(1, '2022-12-19', 20, 10000, 200000, 'BB001', 0);
select * from StrukBeli;

-- 7. Trigger untuk mengupdate stok bahan
drop trigger if exists tUpdateStok;
delimiter $$
create trigger tUpdateStok
before update on Bahan
for each row
BEGIN
    set new.stok = old.stok + new.stok;
END $$
delimiter ;

UPDATE Bahan SET stok = '5' WHERE IDbahan = 'BB004';
select * from Bahan;