CREATE DATABASE InventoriApp;

USE InventoriApp;

CREATE TABLE tb_admin (
  id_admin VARCHAR(10) NOT NULL PRIMARY KEY,
  username VARCHAR NOT NULL,
  nama_panjang VARCHAR(50) NOT NULL,
  password VARCHAR(20) NOT NULL
);

CREATE TABLE tb_kategori (
  id_kategori VARCHAR(10) NOT NULL PRIMARY KEY,
  jenis_kategori VARCHAR NOT NULL
);

CREATE TABLE tb_barang (
  id_barang VARCHAR(10) NOT NULL PRIMARY KEY,
  id_kategori VARCHAR(10) NOT NULL,
  nama_barang VARCHAR NOT NULL,
  CONSTRAINT FK_KATEGORI FOREIGN KEY (id_kategori) REFERENCES tb_kategori(id_kategori),
);

CREATE TABLE tb_barangkeluar (
  id_barangkeluar VARCHAR(10) NOT NULL PRIMARY KEY,
  kode_bk VARCHAR NOT NULL,
  id_kategori VARCHAR(10) NOT NULL,
  id_barang VARCHAR(10) NOT NULL,
  jumlah VARCHAR(10) NOT NULL,
  tanggal date NOT NULL,
  pic VARCHAR NOT NULL,
  CONSTRAINT FK_KATEGORI1 FOREIGN KEY (id_kategori) REFERENCES tb_kategori(id_kategori),
  CONSTRAINT FK_BARANG FOREIGN KEY (id_barang) REFERENCES tb_barang(id_barang)
);

CREATE TABLE tb_barangmasuk (
  id_barangmasuk VARCHAR(10) NOT NULL PRIMARY KEY,
  kode_bm VARCHAR(10) NOT NULL,
  id_kategori VARCHAR(10) NOT NULL,
  id_barang VARCHAR(10) NOT NULL,
  jumlah int NOT NULL,
  tanggal date NOT NULL,
  pic VARCHAR NOT NULL,
  CONSTRAINT FK_KATEGORI2 FOREIGN KEY (id_kategori) REFERENCES tb_kategori(id_kategori),
  CONSTRAINT FK_BARANG1 FOREIGN KEY (id_barang) REFERENCES tb_barang(id_barang)
);

CREATE TABLE tb_opname(
  id_opname VARCHAR(10) NOT NULL PRIMARY KEY,
  kode_so VARCHAR(10) NOT NULL,
  id_kategori VARCHAR(10) NOT NULL,
  id_barang VARCHAR(10) NOT NULL,
  st_sistem int NOT NULL,
  st_fisik int NOT NULL,
  tanggal date NOT NULL,
  pic VARCHAR NOT NULL,
  status VARCHAR NOT NULL,
  CONSTRAINT FK_KATEGORI5 FOREIGN KEY (id_kategori) REFERENCES tb_kategori(id_kategori),
  CONSTRAINT FK_BARANG5 FOREIGN KEY (id_barang) REFERENCES tb_barang(id_barang)
);

CREATE TABLE tb_log (
  id_log VARCHAR(10) NOT NULL PRIMARY KEY,
  id_admin VARCHAR(10) NOT NULL,
  keterangan VARCHAR NOT NULL,
  waktu timestamp NOT NULL,
  CONSTRAINT FK_ADMIN FOREIGN KEY (id_admin) REFERENCES tb_admin(id_admin),
);

CREATE TABLE tb_riwayat (
  id_riwayat VARCHAR(10) NOT NULL PRIMARY KEY,
  tanggal timestamp NOT NULL,
  transaksi VARCHAR NOT NULL,
  id_kategori VARCHAR(10) NOT NULL,
  id_barang VARCHAR(10) NOT NULL,
  jumlah int NOT NULL,
  keterangan VARCHAR NOT NULL,
  id_admin VARCHAR(10) NOT NULL,
  CONSTRAINT FK_KATEGORI3 FOREIGN KEY (id_kategori) REFERENCES tb_kategori(id_kategori),
  CONSTRAINT FK_BARANG2 FOREIGN KEY (id_barang) REFERENCES tb_barang(id_barang),
  CONSTRAINT FK_ADMIN1 FOREIGN KEY (id_admin) REFERENCES tb_admin(id_admin),
 );


