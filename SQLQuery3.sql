
USE Db_Mahasiswa

INSERT INTO Jurusan VALUES
	('J001', 'Teknik Informatika', 'Aktif'),
	('J002', 'Management Informatika', 'Aktif'),
	('J003', 'Sistem Informasi', 'Non Aktif'),
	('J004', 'Sistem Komputer', 'Aktif'),
	('J005', 'Komputer Akuntansi', 'Non Aktif')
--Delete from Jurusan where Kode_Jurusan = 'J001'

insert into Type_Dosen values
	('T001','Tetap'),
	('T002','Honorer'),
	('T003','Expertise')

INSERT INTO Dosen VALUES
	('D001', 'Prof. Dr. Retno Wahyuningsih', 'j001','T001'),
	('D002', 'Prof. Roy M. Sutikno', 'J002','T001'),
	('D003', 'Prof. Hendri A. Verburgh', 'J003','T002'),
	('D004', 'Prof. Risma Suparwata', 'J004', 'T002'),
	('D005', 'Prof. Amir Sjarifuddin Madjid, MM, MA', 'J005', 'T001')

insert into Agama values
	('A001','Islam'),
	('A002','Kristen'),
	('A003','Katolik'),
	('A004','Hindu'),
	('A005','Budha')

INSERT INTO Ujian VALUES
	('U001', 'Algoritma', 'Aktif'),
	('U002', 'Aljabar', 'Aktif'),
	('U003', 'Statistika', 'Non Aktif'),
	('U004', 'Etika Profesi', 'Non Aktif'),
	('U005', 'Bahasa Inggris', 'Aktif')



INSERT INTO Nilai VALUES
	('M004', 'U001', '90'),
	('M001', 'U001', '80'),
	('M002', 'U003', '85'),
	('M004', 'U002', '95'),
	('M005', 'U005', '70')


INSERT INTO Mahasiswa VALUES
	('M001', 'Budi Gunawan', 'Jl. Mawar No 3 RT 05 Cicalengka, Bandung', 'A001', 'J001'),
	('M002', 'Rinto Raharjo', 'Jl. Kebagusan No. 33 RT04 RW06 Bandung', 'A002', 'J002'),
	('M003', 'Asep Saepudin', 'Jl. Sumatera No. 12 RT02 RW01, Ciamis', 'A001', 'J003'),
	('M004', 'M. Hafif Isbullah', 'Jl. Jawa No 01 RT01 RW01, Jakarta Pusat', 'A001', 'J001'),
	('M005', 'Cahyono', 'Jl. Niagara No. 54 RT01 RW09, Surabaya', 'A003', 'J002')


SELECT * FROM Jurusan
SELECT * FROM Agama
SELECT * FROM Mahasiswa
SELECT * FROM Type_Dosen
SELECT * FROM Ujian
SELECT * FROM Dosen
SELECT * FROM Nilai


-- SOAL LATIHAN DARI PAK ATUR 

-- No. 1
CREATE TABLE Jurusan
(
	Id INT IDENTITY(1,1),
	Kode_Jurusan CHAR(5) NOT NULL,
	Nama_Jurusan VARCHAR(50) NOT NULL,
	Status_Jurusan VARCHAR(100) NOT NULL,
	PRIMARY KEY (Kode_Jurusan)
)

CREATE TABLE Agama
(
	Id INT IDENTITY(1,1),
	Kode_Agama CHAR(5) NOT NULL,
	Deskripsi VARCHAR(20) NOT NULL,
	PRIMARY KEY (Kode_Agama)
)

CREATE TABLE Mahasiswa
(
	Id INT IDENTITY(1,1),
	Kode_Mahasiswa CHAR(5) NOT NULL,
	Nama_Mahasiswa VARCHAR(100) NOT NULL,
	Alamat VARCHAR(200) NOT NULL,
	Kode_Agama CHAR(5) NOT NULL,
	Kode_Jurusan CHAR(5) NOT NULL,
	PRIMARY KEY (Kode_Mahasiswa),
	FOREIGN KEY (Kode_Agama) REFERENCES Agama,
	FOREIGN KEY (Kode_Jurusan) REFERENCES Jurusan
)

CREATE TABLE Ujian
(
	Id INT IDENTITY(1,1),
	Kode_Ujian CHAR(5) NOT NULL,
	Nama_Ujian VARCHAR(50) NOT NULL,
	Status_Ujian VARCHAR(100) NOT NULL,
	PRIMARY KEY (Kode_Ujian)
)

CREATE TABLE Type_Dosen
(
	Id INT IDENTITY(1,1),
	Kode_Type_Dosen CHAR(5) NOT NULL,
	Deskripsi VARCHAR(20) NOT NULL,
	PRIMARY KEY (Kode_Type_Dosen)
)

CREATE TABLE Dosen
(
	Id INT IDENTITY(1,1),
	Kode_Dosen CHAR(5) NOT NULL,
	Nama_Dosen VARCHAR(100) NOT NULL,
	Kode_Jurusan CHAR(5) NOT NULL,
	Kode_Type_Dosen CHAR(5) Not NULL
	PRIMARY KEY (Kode_Dosen)
)

CREATE TABLE Nilai
(
	Id INT IDENTITY(1,1),
	Kode_Mahasiswa CHAR(5) NOT NULL,
	Kode_Ujian CHAR(5) NOT NULL,
	Nilai DECIMAL(8, 2) NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (Kode_Mahasiswa) REFERENCES Mahasiswa,
	FOREIGN KEY (Kode_Ujian) REFERENCES Ujian
)



-- NO. 2
ALTER TABLE Dosen ALTER COLUMN Nama_Dosen VARCHAR(200) NOT NULL


-- No. 3
SELECT  Kode_Mahasiswa, Nama_Mahasiswa, Nama_Jurusan, Deskripsi 'Agama'
FROM Mahasiswa M
JOIN Jurusan J ON m.Kode_Jurusan = j.Kode_Jurusan
JOIN Agama A ON M.Kode_Agama = A.Kode_Agama 
WHERE Kode_Mahasiswa LIKE 'M001'

-- No. 4
SELECT Kode_Mahasiswa, Nama_Mahasiswa, Nama_Jurusan, Alamat, Status_Jurusan
FROM Mahasiswa M
JOIN Jurusan J ON M.Kode_Jurusan = J.Kode_Jurusan
WHERE Status_Jurusan = 'Non Aktif'

-- No. 5
SELECT Nama_Mahasiswa, Nama_Jurusan, Alamat, Nilai, Status_Jurusan
FROM Mahasiswa M
JOIN Nilai N ON M.Kode_Mahasiswa = N.Kode_Mahasiswa
JOIN Jurusan J ON M.Kode_Jurusan = J.Kode_Jurusan
WHERE Nilai > 80 AND Status_Jurusan = 'Aktif'

-- No. 6
SELECT * FROM Jurusan where Nama_Jurusan LIKE  '%' + 'sistem' + '%'

-- No. 7
Select * from Mahasiswa where Kode_Mahasiswa = (SELECT Kode_Mahasiswa  
FROM Nilai
GROUP BY Kode_Mahasiswa HAVING count(Kode_Mahasiswa) > 1)



--No. 8
SELECT  Kode_Mahasiswa, Nama_Mahasiswa, Nama_Jurusan, A.Deskripsi 'Agama', Nama_Dosen, Status_Jurusan, T.Deskripsi
FROM Mahasiswa M
JOIN Jurusan J ON m.Kode_Jurusan = j.Kode_Jurusan
JOIN Agama A ON M.Kode_Agama = A.Kode_Agama
JOIN Dosen D ON D.Kode_Jurusan = M.Kode_Jurusan
JOIN Type_Dosen T ON T.Kode_Type_Dosen = D.Kode_Type_Dosen
WHERE Kode_Mahasiswa LIKE 'M001'

--No. 9
Create view Tampil as 
select 
	m.Kode_Mahasiswa, m.Nama_Mahasiswa, j.Nama_jurusan, 
	a.Deskripsi as Agama, d.Nama_Dosen, j.Status_jurusan, t.Deskripsi
from Mahasiswa as m join Jurusan as j 
on m.Kode_Jurusan = j.Kode_Jurusan and
m.Kode_Mahasiswa = 'M001' join Agama as a on m.Kode_Agama = a.Kode_Agama
join Dosen as d on d.Kode_Jurusan = j.Kode_Jurusan
join Type_Dosen as t on d.Kode_type_dosen = t.Kode_Type_Dosen

Select * from Tampil


--No. 10
select * from Mahasiswa full join Nilai on 
Mahasiswa.Kode_Mahasiswa = Nilai.Kode_Mahasiswa 
or 
Mahasiswa.Kode_Mahasiswa!=null