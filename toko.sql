-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 26 Des 2024 pada 04.43
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `toko`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `admin`
--

CREATE TABLE `admin` (
  `id_admin` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `nama_lengkap` varchar(100) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `no_tlp` varchar(20) NOT NULL,
  `jenis_kelamin` enum('L','P') NOT NULL,
  `tgl_lahir` date NOT NULL,
  `level` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data untuk tabel `admin`
--

INSERT INTO `admin` (`id_admin`, `username`, `email`, `password`, `nama_lengkap`, `alamat`, `no_tlp`, `jenis_kelamin`, `tgl_lahir`, `level`) VALUES
(1, 'admin', 'vannvaniarzy@gmail.com', '1234567  ', 'VANIA RUSPRAMESWARI  ', 'Jalan Simorejo Sari A VI No.09  ', '0877-3198-4536  ', 'P', '2005-07-29', 'admin'),
(24, 'desmithaputri_  ', 'desmithaputri27@gmail.com', 'cokelatbiru  ', 'DESMITHA PUTRI NIRMALA  ', 'Jl. Banyu Urip Kidul Gang 4A No.42', '0896-3070-8143  ', 'P', '2003-12-18', 'user'),
(25, 'erika', 'erika29@gmail.com', 'erika', 'erikahjk', 'simorejo', '0877-3198-4536 ', 'P', '2005-04-27', 'user'),
(1026, 'cacaart', 'cacaart123@gmail.com', 'cacaart69', 'Khanza Mutiara', 'Oma Indah Menganti Blok D7', '081234567123', 'P', '2017-04-07', 'admin'),
(100027, 'Ardyaresita', 'ardyaresita@gmail.com', 'ardyacantik', 'Ardya Resita', 'Manukan tengah', '081855184459', 'P', '2005-07-29', 'user');

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_penjualan`
--

CREATE TABLE `detail_penjualan` (
  `id_detail_penjualan` int(11) NOT NULL,
  `id_penjualan` int(11) NOT NULL,
  `id_produk` int(11) NOT NULL,
  `jumlah_produk` int(11) NOT NULL,
  `harga_satuan` int(11) NOT NULL,
  `total_harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `detail_penjualan`
--

INSERT INTO `detail_penjualan` (`id_detail_penjualan`, `id_penjualan`, `id_produk`, `jumlah_produk`, `harga_satuan`, `total_harga`) VALUES
(1, 14, 30, 3, 25000, 75000),
(7, 11, 45, 1, 23000, 23000),
(41, 7, 55, 9, 5000, 45000),
(94, 1, 40, 3, 8000, 24000),
(95, 2, 50, 100, 200, 20000),
(96, 3, 30, 5, 25000, 125000),
(97, 4, 40, 1, 8000, 8000),
(98, 4, 50, 1, 200, 200),
(99, 6, 50, 100, 200, 20000),
(100, 8, 33, 10, 5000, 50000),
(476073, 13, 55, 5, 5000, 25000),
(1000000, 9, 30, 1, 25000, 25000),
(1000001, 10, 21, 10, 15000, 150000),
(1000002, 12, 50, 100, 200, 20000),
(1000003, 13, 30, 3, 25000, 75000),
(1000004, 14, 20, 5, 5000, 25000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `pelanggan`
--

CREATE TABLE `pelanggan` (
  `id_pelanggan` int(11) NOT NULL,
  `nama_pelanggan` varchar(100) NOT NULL,
  `jenis_kelamin` enum('Laki-Laki','Perempuan') NOT NULL,
  `alamat_pelanggan` varchar(100) NOT NULL,
  `no_tlp_pelanggan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `pelanggan`
--

INSERT INTO `pelanggan` (`id_pelanggan`, `nama_pelanggan`, `jenis_kelamin`, `alamat_pelanggan`, `no_tlp_pelanggan`) VALUES
(1, 'Vania Rusprameswari', 'Perempuan', 'Simorejo Sari', '087855184459'),
(2, 'Rizqiyah Hakim', 'Perempuan', 'Ketintang', '08123456789'),
(2003, 'Revian Atheylla ', 'Perempuan', 'Ketintang Barat', '083445678946');

-- --------------------------------------------------------

--
-- Struktur dari tabel `penjualan`
--

CREATE TABLE `penjualan` (
  `id_penjualan` int(20) NOT NULL,
  `tanggal_penjualan` date NOT NULL,
  `jam_penjualan` time NOT NULL,
  `item_penjualan` int(11) NOT NULL,
  `total_penjualan` int(11) NOT NULL,
  `bayar` int(11) NOT NULL,
  `kembali` int(11) NOT NULL,
  `id_pelanggan` int(11) NOT NULL,
  `id_admin` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `penjualan`
--

INSERT INTO `penjualan` (`id_penjualan`, `tanggal_penjualan`, `jam_penjualan`, `item_penjualan`, `total_penjualan`, `bayar`, `kembali`, `id_pelanggan`, `id_admin`) VALUES
(1, '2024-12-11', '22:08:38', 2, 24000, 30000, 6000, 2003, 1),
(2, '2024-12-11', '22:13:43', 2, 20000, 20000, 0, 2003, 1),
(3, '2024-12-11', '22:20:09', 2, 125000, 150000, 25000, 2, 1),
(4, '2024-12-12', '06:28:03', 3, 8200, 10000, 1800, 2003, 1),
(5, '2024-12-12', '06:42:13', 2, 20000, 20000, 0, 2003, 1),
(6, '2024-12-12', '06:53:09', 2, 20000, 20000, 0, 2003, 1),
(7, '2024-12-12', '07:04:12', 2, 45000, 50000, 5000, 2003, 1),
(8, '2024-12-12', '07:14:26', 2, 50000, 50000, 0, 2, 1),
(9, '2024-12-12', '07:20:54', 2, 25000, 50000, 25000, 1, 1),
(10, '2024-12-12', '07:29:11', 2, 150000, 150000, 0, 1, 1),
(11, '2024-12-12', '07:53:40', 2, 23000, 25000, 2000, 1, 1),
(12, '2024-12-12', '08:02:08', 2, 20000, 20000, 0, 2003, 1),
(13, '2024-12-12', '19:04:24', 8, 100000, 100000, 0, 2, 1),
(14, '2024-12-12', '19:39:48', 8, 100000, 100000, 0, 2003, 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `produk`
--

CREATE TABLE `produk` (
  `id_produk` int(11) NOT NULL,
  `nama_produk` varchar(255) NOT NULL,
  `stok_produk` int(11) NOT NULL,
  `harga_produk` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data untuk tabel `produk`
--

INSERT INTO `produk` (`id_produk`, `nama_produk`, `stok_produk`, `harga_produk`) VALUES
(1, 'Egrang Batok Kelapa', 627833, 15000),
(2, 'Egrang Bambu', 3246, 83000),
(3, 'Gasing Kayu', 122455, 25000),
(4, 'Yoyo', 0, 13000),
(5, 'Kelereng', 248, 9500),
(20, 'gasing', -2, 5000),
(21, 'Gasing Bambu', 43, 15000),
(22, 'Kapal Otok-Otok', 0, 10000),
(23, 'Mainan Gamelan Anak', 1, 22000),
(24, 'Dakon', 2, 17000),
(25, 'Hulla Hoop', 15, 12000),
(26, 'Mainan Suling Bambu', 98, 3000),
(27, 'Yoyo Besi', 33, 12000),
(28, 'Dakon Lipat', 0, 95000),
(29, 'Lenggang Rotan', 8, 49000),
(30, 'Pecut Jaranan', 42, 25000),
(31, 'Mainan Kuda Lumping', 2, 45000),
(32, 'Wayang Cepot', 100, 100000),
(33, 'Bola Bekel', 20, 5000),
(34, 'Biji Bekel Plastik', 999, 2000),
(35, 'Biji Bekel Besi', 999, 1500),
(36, 'Mainan Masak-Masakan ', 5, 7000),
(37, 'Latto - Latto', 0, 10000),
(38, 'Pletokan Bambu', 69, 4000),
(39, 'Pistol Karet Gelang', 10, 18000),
(40, 'Ketapel', 30, 8000),
(41, 'Ontong-Ontong / Drum Goyang', 7, 16000),
(42, 'Klotokan Bambu', 8, 5000),
(43, 'Mobil-Mobilan Tradisional', 20, 30000),
(44, 'Mainan Perkusi', 32, 20000),
(45, 'Lompat Tali', 100, 23000),
(46, 'Lompat Tali Karet', 90, 11000),
(47, 'Bakiak', 29, 28000),
(48, 'Kuda-Kudaan Rotan', 40, 150000),
(49, 'Sepak Raga', 80, 40000),
(50, 'Klingsian', 1000, 200),
(51, 'Biji Karet Aduan', 2500, 500),
(52, 'Dam-Daman', 65, 25000),
(53, 'Gatrik', 80, 10000),
(54, 'Boi-Boian', 70, 15000),
(55, 'Mobil-Mobilan Kulit Jeruk', 5, 5000),
(56, 'Mainan Masak-Masakan ', 98, 15000),
(57, 'hbjknil', 0, 0),
(58, 'Catur ', 2, 50000),
(59, 'coba', 9, 8000),
(60, 'coba', 9, 8000),
(61, 'burung', 7, 800),
(62, 'hp', 9, 15000),
(63, 'vania', 7, 900),
(300064, 'ardya', 15, 1000000);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indeks untuk tabel `detail_penjualan`
--
ALTER TABLE `detail_penjualan`
  ADD PRIMARY KEY (`id_detail_penjualan`),
  ADD KEY `id_produk` (`id_produk`),
  ADD KEY `fk_penjualan` (`id_penjualan`);

--
-- Indeks untuk tabel `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`id_pelanggan`);

--
-- Indeks untuk tabel `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`id_penjualan`),
  ADD KEY `id_admin` (`id_admin`),
  ADD KEY `fk_pelanggan` (`id_pelanggan`);

--
-- Indeks untuk tabel `produk`
--
ALTER TABLE `produk`
  ADD PRIMARY KEY (`id_produk`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `admin`
--
ALTER TABLE `admin`
  MODIFY `id_admin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100028;

--
-- AUTO_INCREMENT untuk tabel `detail_penjualan`
--
ALTER TABLE `detail_penjualan`
  MODIFY `id_detail_penjualan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1000005;

--
-- AUTO_INCREMENT untuk tabel `pelanggan`
--
ALTER TABLE `pelanggan`
  MODIFY `id_pelanggan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=200005;

--
-- AUTO_INCREMENT untuk tabel `penjualan`
--
ALTER TABLE `penjualan`
  MODIFY `id_penjualan` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2147483648;

--
-- AUTO_INCREMENT untuk tabel `produk`
--
ALTER TABLE `produk`
  MODIFY `id_produk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=300066;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `detail_penjualan`
--
ALTER TABLE `detail_penjualan`
  ADD CONSTRAINT `detail_penjualan_ibfk_1` FOREIGN KEY (`id_penjualan`) REFERENCES `penjualan` (`id_penjualan`),
  ADD CONSTRAINT `detail_penjualan_ibfk_2` FOREIGN KEY (`id_produk`) REFERENCES `produk` (`id_produk`),
  ADD CONSTRAINT `fk_penjualan` FOREIGN KEY (`id_penjualan`) REFERENCES `penjualan` (`id_penjualan`);

--
-- Ketidakleluasaan untuk tabel `penjualan`
--
ALTER TABLE `penjualan`
  ADD CONSTRAINT `fk_pelanggan` FOREIGN KEY (`id_pelanggan`) REFERENCES `pelanggan` (`id_pelanggan`),
  ADD CONSTRAINT `penjualan_ibfk_1` FOREIGN KEY (`id_pelanggan`) REFERENCES `pelanggan` (`id_pelanggan`),
  ADD CONSTRAINT `penjualan_ibfk_2` FOREIGN KEY (`id_admin`) REFERENCES `admin` (`id_admin`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
