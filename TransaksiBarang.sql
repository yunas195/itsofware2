create database transaksi_barang

use transaksi_barang

create table barang
(
  id char(5) primary key,
  nama varchar(100) not null,
  harga int not null,
  stok int not null 
)

create table pembelian
(
  id char(5) primary key,
  tanggal datetime not null,
  total int not null
)

create table transaksi 
(
  id_barang char(5) not null,
  id_pembelian char(5) not null,
  jumlah int not null,
  harga int not null,

  primary key(id_barang,id_pembelian),
  foreign key (id_barang) references barang(id),
  foreign key (id_pembelian) references pembelian(id)
)