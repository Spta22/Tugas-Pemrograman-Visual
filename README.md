Judul Proyek:
Aplikasi Booking PlayStation Berbasis Desktop dengan Database MySQL

Deskripsi Singkat:
Aplikasi ini dirancang untuk membantu admin dalam mengelola pemesanan (booking) PlayStation secara efisien. Aplikasi berbasis desktop ini terhubung dengan database MySQL untuk menyimpan dan mengelola data secara terstruktur.

Fitur Utama:

Login :
Menu Login
![Login](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20Login.jpeg)
halaman pertama yang ditampilkan setelah splash screen. Form ini berfungsi untuk melakukan otentikasi pengguna dengan memasukkan username dan password. Jika login berhasil, pengguna akan diarahkan ke dashboard utama. Form ini juga menyediakan tombol Buat Akun untuk pengguna baru yang belum memiliki akun, dengan tampilan latar belakang bertema PlayStation yang menarik dan modern.
Di dalam halaman login terdapat beberapa fitur yaitu:
    Input Username dan Password
    Tombol Login untuk masuk ke Dashboard.
    Tombol Buat Akun jika belum memiliki akun.

Buat Akun : 
Menu Buat Akun
![Buat Akun](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20Buat%20Akun.jpeg)
Form Buat Akun digunakan oleh pengguna baru untuk mendaftarkan diri agar dapat mengakses sistem. Pada form ini pengguna diminta mengisi tiga informasi utama: Username, Password, dan Nama. Setelah itu, pengguna dapat menekan tombol Daftar untuk menyimpan data ke database. Form ini juga dilengkapi tombol Kembali untuk kembali ke halaman login apabila pengguna sudah memiliki akun.
Di dalam halaman buat akun terdapat beberapa fitur yaitu:
    Input data pengguna: Username, Password, dan Nama.
    Tombol Daftar untuk menyimpan data pengguna ke database.
    Tombol Kembali untuk kembali ke menu Login.

Dashboard : 
Menu Dashboard
![Dashboard](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20Dashboard.jpeg)
Form Dashboard merupakan pusat navigasi utama aplikasi setelah login berhasil. Di dalamnya terdapat tombol untuk mengakses fitur-fitur penting seperti Booking, Data Booking, Daftar Harga, Kontak WhatsApp Admin, dan Kembali (logout). Tampilan dashboard dibuat sederhana dan elegan dengan logo besar PS5 di tengah layar, membuat pengguna mudah dalam memilih fitur yang diinginkan.
Di Hhalaman Dashboard terdapat beberapa fitur yaitu:
    Booking: Form untuk melakukan pemesanan.
    Data Booking: Menampilkan data semua booking.
    Daftar Harga: Informasi harga sewa berdasarkan durasi.
    Kontak WA Admin: Langsung terhubung ke WhatsApp admin.
    Kembali: Logout ke form login.

Booking :
Menu booking
![Booking](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20Booking.jpeg)
Form Booking digunakan untuk melakukan pemesanan atau sewa tempat bermain Playstation. Pengguna akan diminta mengisi data berupa nama, nomor telepon, pilihan meja, tanggal pemesanan, serta jam mulai dan selesai. Dari informasi tersebut akan dihitung durasi dan harga otomatis. Form ini sangat user-friendly dan didesain dengan background abu-abu serta logo PS yang menonjol.
Di halaman booking terdapat beberapa fitur yaitu:
    Input Nama, Telepon, Meja, Tanggal, Jam Mulai dan Jam Selesai.
    Logo PS ditampilkan sebagai hiasan.
    Tombol Booking untuk menyimpan pemesanan.
    Tombol Kembali ke dashboard.

Data Booking: 
Menu data booking
![Data Booking](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20Data%20Booking.jpeg)
Form ini menampilkan seluruh daftar booking yang sudah masuk ke sistem dalam bentuk tabel (DataGridView). Setiap baris menampilkan informasi lengkap seperti nama penyewa, nomor telepon, tanggal, jam sewa, dan total harga. Fitur pencarian memudahkan untuk mencari data tertentu. Tersedia juga tombol untuk mengedit, menghapus, serta mencetak struk PDF dari data yang dipilih secara langsung.
Dalam halaman data booking terdapat beberapa fitur yaitu:
    Menampilkan daftar booking dalam DataGridView.
    Kolom meliputi: id_booking, Nama, Telepon, Meja, Tanggal, Jam Mulai, Jam Selesai, dan Harga (Rp).
    Fitur pencarian booking.
    Tombol Edit, Hapus, dan Cetak Struk PDF.
    Tombol Kembali ke dashboard.

Daftar Harga : 
Menu Daftar Harga
![Daftar Harga](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20Daftar%20Harga.jpeg)
Form Daftar Harga menampilkan daftar biaya sewa berdasarkan durasi pemakaian per jam. Informasi ini penting sebagai referensi bagi pengguna saat ingin melakukan booking. Harga yang ditampilkan meliputi sewa dari 1 jam hingga 5 jam, dengan tampilan tombol-tombol harga yang besar dan jelas. Form ini memperkuat transparansi informasi biaya kepada pelanggan.
Dalam halaman daftar harga terdapat 2 fitur saja yaitu:
    Menampilkan tarif sewa berdasarkan durasi:
        1 Jam: Rp 5.000
        2 Jam: Rp 9.000
        3 Jam: Rp 14.000
        4 Jam: Rp 17.000
        5 Jam: Rp 20.000
    Tombol Kembali ke dashboard.

Kontak WA :
Menu Kontak Wa
![Kontak Wa](https://github.com/Spta22/Tugas-Pemrograman-Visual/blob/main/Form%20KontaWa.jpeg)
Form ini menyediakan tombol untuk langsung menghubungi admin rental via WhatsApp. Ketika tombol diklik, pengguna akan diarahkan ke halaman chat WhatsApp melalui browser, menggunakan nomor WA admin yang telah diatur sebelumnya. Fitur ini sangat membantu bagi pengguna yang membutuhkan bantuan atau ingin bertanya langsung tanpa harus menyimpan nomor terlebih dahulu.
Dalam halaman kontak wa terdapat 2 fitur saja yaitu:
    Dapat membuka langsung link WhatsApp ke nomor admin saat tombol ditekan:
    Tombol Kembali ke dashboard.

Bahasa Pemrograman: C# (atau bahasa lain sesuai kebutuhan)
Database: MySQL
Tools: Visual Studio, MySQL Workbench (atau phpMyAdmin)

Tujuan:
Memberikan solusi praktis bagi pengelola rental PlayStation untuk mengelola jadwal dan data booking pelanggan secara digital dan terstruktur.
