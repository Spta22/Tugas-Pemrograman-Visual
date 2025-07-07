Judul Proyek:
Aplikasi Booking PlayStation untuk Admin Berbasis Desktop dengan Database MySQL

Deskripsi Singkat:
Aplikasi ini dirancang untuk membantu mengelola pemesanan (booking) PlayStation secara efisien. Aplikasi berbasis desktop ini terhubung dengan database MySQL untuk menyimpan dan mengelola data secara terstruktur.

Fitur Utama:

Menu Login:
Tampilan Login
![Login](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20Login.jpeg)
Form Login adalah halaman pertama yang ditampilkan setelah splash screen. Form ini berfungsi untuk melakukan otentikasi pengguna dengan memasukkan username dan password. Jika login berhasil, pengguna akan diarahkan ke dashboard utama. Form ini juga menyediakan tombol Buat Akun untuk pengguna baru yang belum memiliki akun, dengan tampilan latar belakang bertema PlayStation yang menarik dan modern.

Menu Buat Akun:
Tampilan Buat Akun
![Buat Akun](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20Buat%20Akun.jpeg)
Form Buat Akun digunakan oleh pengguna baru untuk mendaftarkan diri agar dapat mengakses sistem. Pada form ini pengguna diminta mengisi tiga informasi utama: Username, Password, dan Nama. Setelah itu, pengguna dapat menekan tombol Daftar untuk menyimpan data ke database. Form ini juga dilengkapi tombol Kembali untuk kembali ke halaman login apabila pengguna sudah memiliki akun.

Menu Dashboard:
Tampilan Dashboard
![Dashboard](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20Dashboard.jpeg)
Form Dashboard merupakan pusat navigasi utama aplikasi setelah login berhasil. Di dalamnya terdapat tombol untuk mengakses fitur-fitur penting seperti Booking, Data Booking, Daftar Harga,Foto Room, Kontak WhatsApp Admin, dan Kembali (logout). Tampilan dashboard dibuat sederhana dan elegan dengan logo besar PS5 di tengah layar, membuat pengguna mudah dalam memilih fitur yang diinginkan.

Menu Booking:
Tampilan Booking
![Booking](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20Booking.jpeg)
Form Booking digunakan untuk melakukan pemesanan atau sewa tempat bermain Playstation. Pengguna akan diminta mengisi data berupa nama, nomor telepon, pilihan meja, tanggal pemesanan, serta jam mulai dan selesai. Dari informasi tersebut akan dihitung durasi dan harga otomatis. Form ini sangat user-friendly dan didesain dengan background abu-abu serta logo PS yang menonjol.

Menu Data Booking
Tampilan Data Booking
![Data Booking](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20Data%20Booking.jpeg)
Form ini menampilkan seluruh daftar booking yang sudah masuk ke sistem dalam bentuk tabel (DataGridView). Setiap baris menampilkan informasi lengkap seperti nama penyewa, nomor telepon, tanggal, jam sewa, dan total harga. Fitur pencarian memudahkan untuk mencari data tertentu. Tersedia juga tombol untuk mengedit, menghapus, serta mencetak struk PDF dari data yang dipilih secara langsung.

Menu Daftar Harga
Tampilan Daftar Harga
![Daftar Harga](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20Daftar%20Harga.jpeg)
Form Daftar Harga menampilkan daftar biaya sewa berdasarkan durasi pemakaian per jam. Informasi ini penting sebagai referensi bagi pengguna saat ingin melakukan booking. Harga yang ditampilkan meliputi sewa dari 1 jam hingga 5 jam, dengan tampilan tombol-tombol harga yang besar dan jelas. Form ini memperkuat transparansi informasi biaya kepada pelanggan.

Menu Foto Room
Tampilan Foto Room
![Foto Room](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20Foto%20Room.jpeg)
Form ini memungkinkan pelanggan melihat foto-foto ruangan dan meja PlayStation yang tersedia. Terdapat 6 ruangan yang bisa dilihat secara visual melalui tombol atau navigasi gambar. Fitur ini menambah kenyamanan pelanggan sebelum memilih meja untuk dipesan.

Menu Kontak wa
Tampilan Kontak Wa
![Kontak wa](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20KontaWa.jpeg)
Form ini menyediakan tombol untuk langsung menghubungi admin rental via WhatsApp. Ketika tombol diklik, pengguna akan diarahkan ke halaman chat WhatsApp melalui browser, menggunakan nomor WA admin yang telah diatur sebelumnya. Fitur ini sangat membantu bagi pengguna yang membutuhkan bantuan atau ingin bertanya langsung tanpa harus menyimpan nomor terlebih dahulu. 


Teknologi yang Digunakan:
Bahasa Pemrograman: C# (atau bahasa lain sesuai kebutuhan)
Database: MySQL
Tools: Visual Studio, MySQL Workbench (atau phpMyAdmin)

Tujuan:
Memberikan solusi praktis bagi pengelola rental PlayStation untuk mengelola jadwal dan data booking pelanggan secara digital dan terstruktur.
