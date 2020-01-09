Imports Devart.Data.MySql
Imports Pein
Public Class Pasien
    Dim Connect As New ConnectionSQL
    Dim Exc As New BaseExceptionsHandler

    Public Property NoRM As String
    Public Property NamaPasien As String
    Public Property TempatLahir As String
    Public Property TanggalLahir As Date
    Public Property JK As String
    Public Property Alamat As String
    Public Property NDaftar As String
    Public Property TanggalDaftar As DateTime
    Public Property TanggalPulang As DateTime
    Public Property CaraBayar As String
    Public Property Penjamin As String
    Public Property NoDaftarRawatInap As String
    Public Property NamaRuang As String
    Public Property Kelas As String
    Public Property StatusKeluar As String
    Public Property CaraKeluar As String
    Public Property NoRegPenunjang As String

    Public Function SelectRegistrasiScript() As String
        Return <SQL>
        SELECT
            t_pasien.noRekamedis,
						t_registrasi.noDaftar,
						t_registrasirawatinap.noDaftarRawatInap,
						t_registrasi.tglDaftar,
						t_registrasirawatinap.rawatInap,
            t_pasien.nmPasien,
            t_pasien.tempatLahir,
            t_pasien.tglLahir,
            t_pasien.jenisKelamin,
            t_pasien.alamat,
						t_pasien.penjamin,
            t_kelas.kelas,
            t_registrasi.tglPulang,
            t_carabayar.carabayar,                   
            t_statuskeluar.statusKeluar,
            t_carakeluar.caraKeluar
        FROM
            t_pasien
        INNER JOIN t_registrasi ON t_pasien.noRekamedis = t_registrasi.noRekamedis
        INNER JOIN t_carabayar ON t_carabayar.kdCaraBayar = t_registrasi.kdCaraBayar
        INNER JOIN t_registrasirawatinap ON t_registrasi.noDaftar = t_registrasirawatinap.noDaftar
        INNER JOIN t_carakeluar ON t_registrasi.kdCaraKeluar = t_carakeluar.kdCaraKeluar
        INNER JOIN t_statuskeluar ON t_registrasi.kdStatusKeluar = t_statuskeluar.kdStatusKeluar
        INNER JOIN t_tarifkelaskamar ON t_tarifkelaskamar.kdTarifKelasKmr = t_registrasirawatinap.kdTarifKelasKmr
        INNER JOIN t_kelas ON t_kelas.kdKelas = t_tarifkelaskamar.kdKelas
        GROUP BY
                t_pasien.noRekamedis,
                t_pasien.nmPasien
        LIMIT 50
                </SQL>
    End Function
    Protected Function SelectNamaPasienScript() As String
        Return <SQL>
        SELECT
            t_pasien.nmPasien           
        FROM
            t_pasien
        INNER JOIN t_registrasi ON t_pasien.noRekamedis = t_registrasi.noRekamedis
        INNER JOIN t_carabayar ON t_carabayar.kdCaraBayar = t_registrasi.kdCaraBayar
        INNER JOIN t_registrasirawatinap ON t_registrasi.noDaftar = t_registrasirawatinap.noDaftar
        INNER JOIN t_carakeluar ON t_registrasi.kdCaraKeluar = t_carakeluar.kdCaraKeluar
        INNER JOIN t_statuskeluar ON t_registrasi.kdStatusKeluar = t_statuskeluar.kdStatusKeluar
        INNER JOIN t_tarifkelaskamar ON t_tarifkelaskamar.kdTarifKelasKmr = t_registrasirawatinap.kdTarifKelasKmr
        INNER JOIN t_kelas ON t_kelas.kdKelas = t_tarifkelaskamar.kdKelas
        GROUP BY
                t_pasien.noRekamedis,
                t_pasien.nmPasien
               </SQL>
    End Function
    Protected Function SelectNoRMScript() As String
        Return <SQL>
        SELECT
            t_pasien.noRekamedis           
        FROM
            t_pasien
        INNER JOIN t_registrasi ON t_pasien.noRekamedis = t_registrasi.noRekamedis
        INNER JOIN t_carabayar ON t_carabayar.kdCaraBayar = t_registrasi.kdCaraBayar
        INNER JOIN t_registrasirawatinap ON t_registrasi.noDaftar = t_registrasirawatinap.noDaftar
        INNER JOIN t_carakeluar ON t_registrasi.kdCaraKeluar = t_carakeluar.kdCaraKeluar
        INNER JOIN t_statuskeluar ON t_registrasi.kdStatusKeluar = t_statuskeluar.kdStatusKeluar
        INNER JOIN t_tarifkelaskamar ON t_tarifkelaskamar.kdTarifKelasKmr = t_registrasirawatinap.kdTarifKelasKmr
        INNER JOIN t_kelas ON t_kelas.kdKelas = t_tarifkelaskamar.kdKelas
        GROUP BY
                t_pasien.noRekamedis,
                t_pasien.nmPasien
               </SQL>
    End Function
    Public Function DataRegistrasiPasien() As DataTable
        Dim dt As New DataTable
        Using cn As New MySqlConnection With {.ConnectionString = Connect.con}
            Using cmd As New MySqlCommand With {.Connection = cn}
                cmd.CommandText = SelectRegistrasiScript()

                Try
                    cn.Open()

                    dt.Load(cmd.ExecuteReader)
                    dt.Columns("noRekamedis").ColumnName = "No.RM"
                    dt.Columns("nmPasien").ColumnName = "Nama"
                    dt.Columns("tempatLahir").ColumnName = "Tempat Lahir"
                    dt.Columns("tglLahir").ColumnName = "Tanggal Lahir"
                    dt.Columns("jenisKelamin").ColumnName = "Jenis Kelamin"
                    dt.Columns("alamat").ColumnName = "Alamat"
                    dt.Columns("noDaftar").ColumnName = "No Registrasi"
                    dt.Columns("tglDaftar").ColumnName = "Tanggal Registrasi"
                    dt.Columns("tglPulang").ColumnName = "Tanggal Pulang"
                    dt.Columns("carabayar").ColumnName = "Cara Bayar"
                    dt.Columns("penjamin").ColumnName = "Penjamin"
                    dt.Columns("noDaftarRawatInap").ColumnName = "No Daftar Rawat Inap"
                    dt.Columns("rawatInap").ColumnName = "Ruang"
                    dt.Columns("kelas").ColumnName = "Kelas"
                    dt.Columns("statusKeluar").ColumnName = "Status Keluar"
                    dt.Columns("caraKeluar").ColumnName = "Cara Keluar"


                Catch ex As Exception
                    Exc.mHasException = True
                    Exc.mLastException = ex
                End Try
            End Using
        End Using

        Return dt
    End Function
    Public Function LoadAutoNama() As AutoCompleteStringCollection
        Dim TheNameList As New AutoCompleteStringCollection

        Using cn As New MySqlConnection With
                {
                    .ConnectionString = Connect.con
                }
            Using cmd As New MySqlCommand With {.Connection = cn}
                cmd.CommandText = SelectNamaPasienScript()
                cn.Open()
                Dim Reader As MySqlDataReader = cmd.ExecuteReader

                If Reader.HasRows Then
                    While Reader.Read
                        TheNameList.Add(Reader.GetString(0))
                    End While

                    Reader.Close()

                End If

            End Using
        End Using

        Return TheNameList

    End Function
    Public Function LoadAutoNoRM() As AutoCompleteStringCollection
        Dim TheNameList As New AutoCompleteStringCollection

        Using cn As New MySqlConnection With
                {
                    .ConnectionString = Connect.con
                }
            Using cmd As New MySqlCommand With {.Connection = cn}
                cmd.CommandText = SelectNoRMScript()
                cn.Open()
                Dim Reader As MySqlDataReader = cmd.ExecuteReader

                If Reader.HasRows Then
                    While Reader.Read
                        TheNameList.Add(Reader.GetString(0))
                    End While

                    Reader.Close()

                End If

            End Using
        End Using

        Return TheNameList

    End Function
#Region "Ambil Data Berdasar No RM"
    Public Function SelectAmbilRegistrasiScript() As String
        Return <SQL>
        SELECT
            t_pasien.noRekamedis,
            t_pasien.nmPasien,
            t_pasien.tempatLahir,
            t_pasien.tglLahir,
            t_pasien.jenisKelamin,
            t_pasien.alamat,
            t_registrasi.noDaftar,
            t_registrasi.tglDaftar,
            t_registrasi.tglPulang,
            t_carabayar.carabayar,
            t_pasien.penjamin,
            t_registrasirawatinap.noDaftarRawatInap,
            t_registrasirawatinap.rawatInap,
            t_kelas.kelas,
            t_statuskeluar.statusKeluar,
            t_carakeluar.caraKeluar
        FROM
            t_pasien
        INNER JOIN t_registrasi ON t_pasien.noRekamedis = t_registrasi.noRekamedis
        INNER JOIN t_carabayar ON t_carabayar.kdCaraBayar = t_registrasi.kdCaraBayar
        INNER JOIN t_registrasirawatinap ON t_registrasi.noDaftar = t_registrasirawatinap.noDaftar
        INNER JOIN t_carakeluar ON t_registrasi.kdCaraKeluar = t_carakeluar.kdCaraKeluar
        INNER JOIN t_statuskeluar ON t_registrasi.kdStatusKeluar = t_statuskeluar.kdStatusKeluar
        INNER JOIN t_tarifkelaskamar ON t_tarifkelaskamar.kdTarifKelasKmr = t_registrasirawatinap.kdTarifKelasKmr
        INNER JOIN t_kelas ON t_kelas.kdKelas = t_tarifkelaskamar.kdKelas
        WHERE   t_pasien.noRekamedis = @noRekamedis
        GROUP BY
                t_pasien.noRekamedis,
                t_pasien.nmPasien
                </SQL>
    End Function
    Public Function AmbilNoRegistrasi(ByRef RM As String) As String
        Exc.mHasException = False

        Dim selectStatement As String = SelectAmbilRegistrasiScript()

        Try
            Using cn = New MySqlConnection(Connect.con)
                Using cmd = New MySqlCommand() With {.Connection = cn, .CommandText = selectStatement}
                    cmd.Parameters.AddWithValue("@noRekamedis", RM)
                    cn.Open()

                    Dim reader As MySqlDataReader = cmd.ExecuteReader

                    If reader.HasRows Then
                        reader.Read()

                        NoRM = NoRM
                        NoRM = reader.GetString(0)
                        NamaPasien = reader.GetString(1)
                        TempatLahir = reader.GetString(2)
                        TanggalLahir = reader.GetDateTime(3)
                        JK = reader.GetString(4)
                        Alamat = reader.GetString(5)
                        NDaftar = reader.GetString(6)
                        TanggalDaftar = reader.GetDateTime(7)
                        TanggalPulang = reader.GetDateTime(8)
                        CaraBayar = reader.GetString(9)
                        Penjamin = reader.GetString(10)
                        NoDaftarRawatInap = reader.GetString(11)
                        NamaRuang = reader.GetString(12)
                        Kelas = reader.GetString(13)
                        StatusKeluar = reader.GetString(14)
                        CaraKeluar = reader.GetString(15)

                    End If
                End Using
            End Using
        Catch ex As Exception
            Exc.mHasException = True
            Exc.mLastException = ex
        End Try

        Return Exc.IsSuccessFul

    End Function
    Public Function SelectAmbilRegPenunjangScript() As String
        Return <SQL>
        SELECT
            t_pasien.noRekamedis,
            t_pasien.nmPasien,
            t_pasien.tempatLahir,
            t_pasien.tglLahir,
            t_pasien.jenisKelamin,
            t_pasien.alamat,
            t_registrasi.noDaftar,
            t_registrasi.tglDaftar,
            t_registrasi.tglPulang,
            t_carabayar.carabayar,
            t_pasien.penjamin,
            t_registrasirawatinap.noDaftarRawatInap,
            t_registrasirawatinap.rawatInap,
            t_kelas.kelas,
            t_statuskeluar.statusKeluar,
            t_carakeluar.caraKeluar,
            t_registrasipenunjangranap.noRegistrasiPenunjangRanap
        FROM
            t_pasien
        INNER JOIN t_registrasi ON t_pasien.noRekamedis = t_registrasi.noRekamedis
        INNER JOIN t_carabayar ON t_carabayar.kdCaraBayar = t_registrasi.kdCaraBayar
        INNER JOIN t_registrasirawatinap ON t_registrasi.noDaftar = t_registrasirawatinap.noDaftar
        INNER JOIN t_carakeluar ON t_registrasi.kdCaraKeluar = t_carakeluar.kdCaraKeluar
        INNER JOIN t_statuskeluar ON t_registrasi.kdStatusKeluar = t_statuskeluar.kdStatusKeluar
        INNER JOIN t_tarifkelaskamar ON t_tarifkelaskamar.kdTarifKelasKmr = t_registrasirawatinap.kdTarifKelasKmr
        INNER JOIN t_kelas ON t_kelas.kdKelas = t_tarifkelaskamar.kdKelas
        INNER JOIN t_registrasipenunjangranap ON t_registrasi.noDaftar = t_registrasipenunjangranap.noDaftar
        WHERE   t_pasien.noRekamedis = @noRekamedis
        GROUP BY
            t_pasien.noRekamedis,
            t_pasien.nmPasien
                </SQL>
    End Function
    Public Function AmbilNoRegistrasiPenunjang(ByRef RM As String) As String
        Exc.mHasException = False

        Dim selectStatement As String = SelectAmbilRegistrasiScript()

        Try
            Using cn = New MySqlConnection(Connect.con)
                Using cmd = New MySqlCommand() With {.Connection = cn, .CommandText = selectStatement}
                    cmd.Parameters.AddWithValue("@noRekamedis", RM)
                    cn.Open()

                    Dim reader As MySqlDataReader = cmd.ExecuteReader

                    If reader.HasRows Then
                        reader.Read()

                        NoRM = NoRM
                        NoRM = reader.GetString(0)
                        NamaPasien = reader.GetString(1)
                        TempatLahir = reader.GetString(2)
                        TanggalLahir = reader.GetDateTime(3)
                        JK = reader.GetString(4)
                        Alamat = reader.GetString(5)
                        NDaftar = reader.GetString(6)
                        TanggalDaftar = reader.GetDateTime(7)
                        TanggalPulang = reader.GetDateTime(8)
                        CaraBayar = reader.GetString(9)
                        Penjamin = reader.GetString(10)
                        NoDaftarRawatInap = reader.GetString(11)
                        NamaRuang = reader.GetString(12)
                        Kelas = reader.GetString(13)
                        StatusKeluar = reader.GetString(14)
                        CaraKeluar = reader.GetString(15)
                        NoRegPenunjang = reader.GetString(16)
                    End If
                End Using
            End Using
        Catch ex As Exception
            Exc.mHasException = True
            Exc.mLastException = ex
        End Try

        Return Exc.IsSuccessFul

    End Function
#End Region
    Public Function isExist(NoRM) As Boolean
        Dim Retries As Integer
        Using cn As New MySqlConnection With {.ConnectionString = Connect.con}

            Using cmd As New MySqlCommand With
                {
                    .Connection = cn,
                    .CommandText = SelectAmbilRegistrasiScript()
                }
                cmd.Parameters.AddWithValue("@noRekamedis", NoRM)

                'cmd.Parameters.AddWithValue("@NAMABAHAN", "%" + bNAMABAHAN + "%")
                Try
                    cn.Open()
                Catch ex As Exception
                    If ex.Message.ToLower.Contains("Data tidak valid") Then
                        Return False
                    Else
                        Throw ex
                    End If
                End Try


                Dim Reader = cmd.ExecuteScalar
                If Reader IsNot Nothing Then
                    Retries = 0
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using

        Return False

    End Function
End Class
