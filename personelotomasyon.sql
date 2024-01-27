-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 20 Oca 2024, 23:55:43
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `personelotomasyon`
--

--
-- Tablo için tablo yapısı `izin`
--

CREATE TABLE `izin` (
  `id` int(11) NOT NULL,
  `adsoyad` varchar(255) NOT NULL,
  `sebep` varchar(255) NOT NULL,
  `sicil_no` varchar(255) NOT NULL,
  `tarih` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `izin`
--

INSERT INTO `izin` (`id`, `adsoyad`, `sebep`, `sicil_no`, `tarih`) VALUES
(62, ' Yusuf Uzun', 'Zİyaret', '111', '2024-01-22'),
(61, ' Ali Han', 'Hasta', '102', '2024-01-22');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `mesai`
--

CREATE TABLE `mesai` (
  `id` int(11) NOT NULL,
  `ad` varchar(255) NOT NULL,
  `soyad` varchar(255) NOT NULL,
  `sicil_no` varchar(50) NOT NULL,
  `tarih_saat` varchar(50) NOT NULL,
  `tarih_gun` date DEFAULT NULL,
  `bolge` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `mesai`
--

INSERT INTO `mesai` (`id`, `ad`, `soyad`, `sicil_no`, `tarih_saat`, `tarih_gun`, `bolge`) VALUES
(0, '', 'Sevda Ataç', '1045', '2024-01-01', NULL, NULL),
(0, 'Ahmet Berkay', 'Memiş', '12', '8', NULL, NULL),
(0, 'Enes', 'Top', '13', '8', NULL, NULL),
(0, 'Murat ', 'Albayrak', '103', '8', NULL, NULL),
(0, 'Sevda', 'Ataç', '1045', '8', NULL, NULL),
(0, 'Cihan', 'Kara', '1070', '8', NULL, NULL),
(0, 'Ali', 'Han', '102', '8', NULL, NULL),
(0, '', 'Ali Han', '102', '2024-01-01', NULL, NULL),
(0, 'Yusuf', 'Uzun', '111', '09.00 - 17.00', '2024-01-07', 'Kampüs İçi'),
(0, 'Ali', 'Han', '102', '8', NULL, NULL),
(0, 'Cihan', 'Kara', '1070', '8', NULL, NULL),
(0, 'Sevda', 'Ataç', '1045', '8', NULL, NULL),
(0, 'Murat ', 'Albayrak', '103', '8', NULL, NULL),
(0, 'Enes', 'Top', '13', '8', NULL, NULL),
(0, 'Ahmet Berkay', 'Memiş', '12', '8', NULL, NULL),
(0, 'Ali', 'Han', '102', '08.00 - 16.00', '2024-01-16', 'Kampüs İçi'),
(0, 'Yusuf', 'Uzun', '111', '00.00 - 08.00', '2024-01-07', 'Kampüs Giriş'),
(0, 'Yusuf', 'Uzun', '111', '08.00 - 16.00', '2024-01-22', 'Kampüs Giriş'),
(0, 'Ali', 'Han', '102', '8', NULL, NULL),
(0, 'Cihan', 'Kara', '1070', '8', NULL, NULL),
(0, 'Sevda', 'Ataç', '1045', '8', NULL, NULL),
(0, 'Murat ', 'Albayrak', '103', '8', NULL, NULL),
(0, 'Enes', 'Top', '13', '8', NULL, NULL),
(0, 'Ahmet Berkay', 'Memiş', '12', '8', NULL, NULL);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ozelgun`
--

CREATE TABLE `ozelgun` (
  `id` int(11) NOT NULL,
  `tarih` date NOT NULL,
  `ad` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `ozelgun`
--

INSERT INTO `ozelgun` (`id`, `tarih`, `ad`) VALUES
(17, '2024-04-10', 'Ramazan Bayramı'),
(16, '2024-04-11', 'Ramazan Bayramı'),
(18, '2024-04-12', 'Ramazan Bayramı'),
(19, '2024-06-16', 'Kurban Bayramı'),
(20, '2024-06-17', 'Kurban Bayramı'),
(21, '2024-06-18', 'Kurban Bayramı'),
(22, '2024-06-19', 'Kurban Bayramı'),
(23, '2024-01-15', 'kk');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personel`
--

CREATE TABLE `personel` (
  `id` int(11) NOT NULL,
  `ad` varchar(255) NOT NULL,
  `soyad` varchar(255) NOT NULL,
  `rol` varchar(50) NOT NULL DEFAULT 'Kullanıcı',
  `sicil_no` int(11) NOT NULL,
  `kadro` varchar(255) NOT NULL,
  `unvan` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `sifre` varchar(255) NOT NULL,
  `telefon` varchar(50) NOT NULL,
  `tc_no` varchar(50) NOT NULL,
  `adres` varchar(300) NOT NULL,
  `izin_1` varchar(50) NOT NULL,
  `izin_2` varchar(50) DEFAULT NULL,
  `prim` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `personel`
--

INSERT INTO `personel` (`id`, `ad`, `soyad`, `rol`, `sicil_no`, `kadro`, `unvan`, `email`, `sifre`, `telefon`, `tc_no`, `adres`, `izin_1`, `izin_2`, `prim`) VALUES
(11, 'Ali', 'Han', 'Kullanıcı', 102, 'Memur', 'Akademisyen', 'alihan@mail.com', '123', '05105013229', '70323289011', 'Bursa', 'Monday', 'Sunday', 60000),
(18, 'Cihan', 'Kara', 'Kullanıcı', 1070, 'İşçi', 'Güvenlik', 'cihankara@mail.com', '123', '05206083124', '78906532145', 'Bursa', 'Saturday', '', 32000),
(19, 'Sevda', 'Ataç', 'Kullanıcı', 1045, 'Memur', 'Güvenlik', 'satac@mail.com', '123', '05607023124', '70322680672', 'Bursa', 'Monday', 'Tuesday', 30000),
(1, 'Murat ', 'Albayrak', 'Yönetici', 103, 'Yönetici', 'Müdür', 'muratalbayrak@email.com', '4545', '05309083123', '79231590871', 'Bursa', 'Saturday', 'Sunday', 50000),
(33, 'Ali', 'Han', 'Kullanıcı', 102, 'Memur', 'Akademisyen', 'alihan@mail.com', '123', '05105013229', '70323289011', 'Bursa', 'Monday', 'Sunday', NULL),
(22, 'Enes', 'Top', 'Kullanıcı', 13, 'İşçi', 'Vasıfsız', 'enestop@mail.com', '123', '05105013252', '70323289019', 'Bursa', '', 'Sunday', NULL),
(30, 'Ahmet Berkay', 'Memiş', 'Kullanıcı', 12, 'İşçi', 'İşsiz', 'berkaymemis@email.com', 'berkaymemis', '05105011235', '70323289998', 'Bursa', '', 'Sunday', NULL),
(29, 'Mekan', 'Geçer', 'Kullanıcı', 11, 'İşçi', 'Vasıfsız', 'mekangecer@email.com', 'mekangecer', '05105011234', '70323289999', 'Bursa', '', 'Sunday', NULL),
(31, 'Yusuf', 'Uzun', 'Kullanıcı', 111, 'Memur', 'Akademisyen', 'y@mail.com', '123', '05105013225', '70323265013', 'Bursa\r\n', 'Saturday', 'Sunday', NULL);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `vardiya`
--

CREATE TABLE `vardiya` (
  `id` int(11) NOT NULL,
  `ad` varchar(255) NOT NULL,
  `soyad` varchar(255) NOT NULL,
  `sicil_no` varchar(100) NOT NULL,
  `tarih_gun` date NOT NULL,
  `tarih_saat` varchar(50) NOT NULL,
  `bolge` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `izin`
--
ALTER TABLE `izin`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `ozelgun`
--
ALTER TABLE `ozelgun`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `personel`
--
ALTER TABLE `personel`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `vardiya`
--
ALTER TABLE `vardiya`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `izin`
--
ALTER TABLE `izin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- Tablo için AUTO_INCREMENT değeri `ozelgun`
--
ALTER TABLE `ozelgun`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- Tablo için AUTO_INCREMENT değeri `personel`
--
ALTER TABLE `personel`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- Tablo için AUTO_INCREMENT değeri `vardiya`
--
ALTER TABLE `vardiya`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1428;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
