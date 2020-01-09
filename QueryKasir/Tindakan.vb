Imports Devart.Data.MySql
Imports Pein
Public Class Tindakan
    Dim Connect As New ConnectionSQL
    Dim Exc As New BaseExceptionsHandler

    Public Property ToTarifTindakan As Double = 0

#Region "Query"
    Public Function SelectDetailTindakan() As String
        Return <SQL>
            SELECT
                t_pasien.noRekamedis,
                t_pasien.nmPasien,
                t_registrasi.noDaftar,
                t_detailtindakanpasienranap.tindakan,
                t_tindakanpasienranap.tglTindakan,
                t_tindakanpasienranap.totalTarifTindakan,
                t_tindakanpasienranap.statusPembayaran,
                t_detailtindakanpasienranap.tarif,
                t_detailtindakanpasienranap.totalTarif,
                t_tindakanpasienranap.noTindakanPasienRanap,
                t_detailtindakanpasienranap.jumlahTindakan,
                t_detailtindakanpasienranap.kdTenagaMedis,
                t_tenagamedis2.namapetugasMedis
            FROM
                t_pasien
            INNER JOIN t_registrasi ON t_pasien.noRekamedis = t_registrasi.noRekamedis
            INNER JOIN t_registrasirawatinap ON t_registrasi.noDaftar = t_registrasirawatinap.noDaftar
            INNER JOIN t_tindakanpasienranap ON t_registrasirawatinap.noDaftarRawatInap = t_tindakanpasienranap.noDaftarRawatInap
            INNER JOIN t_detailtindakanpasienranap ON t_tindakanpasienranap.noTindakanPasienRanap = t_detailtindakanpasienranap.noTindakanPasienRanap
            INNER JOIN t_tenagamedis2 ON t_tenagamedis2.kdPetugasMedis = t_detailtindakanpasienranap.kdTenagaMedis
            WHERE t_registrasi.noDaftar = @noDaftar
            GROUP BY
                t_detailtindakanpasienranap.idTindakanPasienRanap
               </SQL>
    End Function
    Public Function SelectTindakanSetScript() As String
        Return <SQL>
            SELECT
                t_pasien.noRekamedis,
                t_pasien.nmPasien,
                t_registrasi.noDaftar,
                t_detailtindakanpasienranap.tindakan,
                t_tindakanpasienranap.tglTindakan,
                t_tindakanpasienranap.totalTarifTindakan,
                t_tindakanpasienranap.statusPembayaran,
                t_detailtindakanpasienranap.tarif,
                t_detailtindakanpasienranap.totalTarif,
                t_tindakanpasienranap.noTindakanPasienRanap,
                t_detailtindakanpasienranap.jumlahTindakan,
                t_detailtindakanpasienranap.kdTenagaMedis,
                t_tenagamedis2.namapetugasMedis
            FROM
                t_pasien
            INNER JOIN t_registrasi ON t_pasien.noRekamedis = t_registrasi.noRekamedis
            INNER JOIN t_registrasirawatinap ON t_registrasi.noDaftar = t_registrasirawatinap.noDaftar
            INNER JOIN t_tindakanpasienranap ON t_registrasirawatinap.noDaftarRawatInap = t_tindakanpasienranap.noDaftarRawatInap
            INNER JOIN t_detailtindakanpasienranap ON t_tindakanpasienranap.noTindakanPasienRanap = t_detailtindakanpasienranap.noTindakanPasienRanap
            INNER JOIN t_tenagamedis2 ON t_tenagamedis2.kdPetugasMedis = t_detailtindakanpasienranap.kdTenagaMedis
            GROUP BY
                t_detailtindakanpasienranap.idTindakanPasienRanap
               </SQL>
    End Function
    Public Function UpdateStatusBayarScript() As String
        Return <SQL>
	        UPDATE  t_pasien as B
			INNER JOIN t_registrasi AS C ON B.noRekamedis = C.noRekamedis
            INNER JOIN t_registrasirawatinap AS D ON C.noDaftar = D.noDaftar
            INNER JOIN t_tindakanpasienranap AS A ON D.noDaftarRawatInap = A.noDaftarRawatInap
            INNER JOIN t_detailtindakanpasienranap AS E ON A.noTindakanPasienRanap = E.noTindakanPasienRanap
            SET A.statusPembayaran = @statusPembayaran
			WHERE  D.noDaftar  = @noDaftar
        </SQL>.Value
    End Function

    'Not Joined
    Public Function UpdateStatusTindakanPasienRanap() As String
        Return <SQL>
            UPDATE  t_tindakanpasienranap
			   SET t_tindakanpasienranap.statusPembayaran = @statusPembayaran
			WHERE  t_tindakanpasienranap.noTindakanPasienRanap  = @noTindakanPasienRanap
               </SQL>
    End Function
#End Region

#Region "Experimental"
    Public Function SelectNoDaftarScript() As String
        Return <SQL>
            SELECT
                t_registrasi.noDaftar,
                t_registrasirawatinap.noDaftarRawatInap,
                t_tindakanpasienranap.noTindakanPasienRanap,
                t_tindakanpasienranap.tglTindakan,
                t_tindakanpasienranap.statusPembayaran
            FROM
                t_registrasi
            INNER JOIN t_registrasirawatinap ON t_registrasi.noDaftar = t_registrasirawatinap.noDaftar
            INNER JOIN t_tindakanpasienranap ON t_registrasirawatinap.noDaftarRawatInap = t_tindakanpasienranap.noDaftarRawatInap
            WHERE
                t_registrasi.noDaftar = @noDaftar
            GROUP BY
                t_tindakanpasienranap.tglTindakan
                </SQL>
    End Function
    Public Function SelectNoTindakanScript() As String
        Return <SQL>
            SELECT
                t_tindakanpasienranap.noTindakanPasienRanap,
                t_tindakanpasienranap.tglTindakan,
                t_tindakanpasienranap.statusPembayaran
            FROM
                t_registrasi
            INNER JOIN t_registrasirawatinap ON t_registrasi.noDaftar = t_registrasirawatinap.noDaftar
            INNER JOIN t_tindakanpasienranap ON t_registrasirawatinap.noDaftarRawatInap = t_tindakanpasienranap.noDaftarRawatInap
            WHERE
                t_registrasi.noTindakanPasienRanap = @noTindakanPasienRanap
            GROUP BY
                t_tindakanpasienranap.tglTindakan
                </SQL>
    End Function
    Public Function SelectTindakanRelationScript() As String
        Return <SQL>
        SELECT
            t_registrasirawatinap.noDaftar,
            t_tindakanpasienranap.noDaftarRawatInap,
            t_tindakanpasienranap.noTindakanPasienRanap,
            t_detailtindakanpasienranap.tindakan,
            t_detailtindakanpasienranap.tarif,
            t_detailtindakanpasienranap.jumlahTindakan,
            t_detailtindakanpasienranap.totalTarif,
            t_tenagamedis2.namapetugasMedis
        FROM
            t_registrasirawatinap
        INNER JOIN t_tindakanpasienranap ON t_registrasirawatinap.noDaftarRawatInap = t_tindakanpasienranap.noDaftarRawatInap
        INNER JOIN t_detailtindakanpasienranap ON t_tindakanpasienranap.noTindakanPasienRanap = t_detailtindakanpasienranap.noTindakanPasienRanap
        INNER JOIN t_tenagamedis2 ON t_tenagamedis2.kdPetugasMedis = t_detailtindakanpasienranap.kdTenagaMedis
        GROUP BY
            t_tindakanpasienranap.tglTindakan,
            t_detailtindakanpasienranap.idTindakanPasienRanap
               </SQL>
    End Function

    'Total Tarif Lunas
    Public Function GetTotalTarifLunas() As String
        Return <SQL>
            SELECT
                Sum(t_detailtindakanpasienranap.totalTarif)
            FROM
                t_registrasi
            INNER JOIN t_registrasirawatinap ON t_registrasi.noDaftar = t_registrasirawatinap.noDaftar
            INNER JOIN t_tindakanpasienranap ON t_registrasirawatinap.noDaftarRawatInap = t_tindakanpasienranap.noDaftarRawatInap
            INNER JOIN t_detailtindakanpasienranap ON t_tindakanpasienranap.noTindakanPasienRanap = t_detailtindakanpasienranap.noTindakanPasienRanap
            WHERE
                t_tindakanpasienranap.statusPembayaran = 'LUNAS' AND t_registrasi.noDaftar=@noDaftar
            GROUP BY
                t_registrasi.noDaftar
               </SQL>
    End Function
    Public Function AmbilNoTarif(ByRef nDaftar As String) As String
        Exc.mHasException = False
        Dim selectStatement As String = GetTotalTarifLunas()
        Try
            Using cn = New MySqlConnection(Connect.con)
                Using cmd = New MySqlCommand() With {.Connection = cn, .CommandText = selectStatement}
                    cmd.Parameters.AddWithValue("@noDaftar", nDaftar)
                    cn.Open()

                    Dim reader As MySqlDataReader = cmd.ExecuteReader

                    If reader.HasRows Then
                        reader.Read()

                        nDaftar = nDaftar
                        ToTarifTindakan = reader.GetDouble(0)
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

    Public Function AmbilNoDaftar(ByVal NoDaft As String) As DataTable
        Dim dt As New DataTable
        Using cn As New MySqlConnection With {.ConnectionString = Connect.con}
            Using cmd As New MySqlCommand With {.Connection = cn}
                cmd.CommandText = SelectDetailTindakan()
                cmd.Parameters.AddWithValue("@noDaftar", NoDaft)
                Try
                    cn.Open()
                    dt.Load(cmd.ExecuteReader)


                    dt.Columns("noDaftar").ColumnName = "No Daftar"
                    dt.Columns("tindakan").ColumnName = "Jenis Tindakan"
                    dt.Columns("tglTindakan").ColumnName = "Tanggal Tindakan"
                    dt.Columns("totalTarifTindakan").ColumnName = "Sub Total"
                    dt.Columns("statusPembayaran").ColumnName = "Status Pembayaran"
                    dt.Columns("tarif").ColumnName = "Tarif"
                    dt.Columns("totalTarif").ColumnName = "Total Tarif"
                    dt.Columns("namapetugasMedis").ColumnName = "Petugas"

                    dt.Columns("noRekamedis").ColumnMapping = MappingType.Hidden
                    dt.Columns("nmPasien").ColumnMapping = MappingType.Hidden
                    dt.Columns("noTindakanPasienRanap").ColumnMapping = MappingType.Hidden
                    dt.Columns("jumlahTindakan").ColumnMapping = MappingType.Hidden
                    dt.Columns("kdTenagaMedis").ColumnMapping = MappingType.Hidden

                Catch ex As Exception
                    Exc.mHasException = True
                    Exc.mLastException = ex
                End Try
            End Using
        End Using

        Return dt

    End Function
    Public Function DataSemuaPasien(ByVal NoDaft As String) As DataSet
        ' Dim dt As New DataTable
        Dim ds As New DataSet()
        Using cn As New MySqlConnection With {.ConnectionString = Connect.con}
            Using cmd As New MySqlCommand With {.Connection = cn}

                cmd.CommandText = SelectNoDaftarScript()
                cmd.Parameters.AddWithValue("@noDaftar", NoDaft)
                Dim da As New MySqlDataAdapter(cmd)

                Try
                    'ds = New DataSet()
                    cn.Open()
                    da.Fill(ds, "Pasien")

                    CType(New MySqlDataAdapter(SelectTindakanRelationScript, cn), MySqlDataAdapter).Fill(ds, "Tindakan")

                    ds.Tables("Pasien").Columns("noDaftar").ColumnMapping = MappingType.Hidden
                    ds.Tables("Pasien").Columns("noDaftarRawatInap").ColumnMapping = MappingType.Hidden
                    ds.Tables("Tindakan").Columns("noDaftar").ColumnMapping = MappingType.Hidden
                    ds.Tables("Tindakan").Columns("noDaftarRawatInap").ColumnMapping = MappingType.Hidden

                    ds.Tables("Pasien").Columns("noDaftar").ColumnName = "No.Registrasi"
                    ds.Tables("Pasien").Columns("noDaftarRawatInap").ColumnName = "No. Daftar Rawat Inap"
                    ds.Tables("Pasien").Columns("noTindakanPasienRanap").ColumnName = "No. Tindakan Pasien"
                    ds.Tables("Pasien").Columns("tglTindakan").ColumnName = "Tanggal Tindakan"
                    ds.Tables("Pasien").Columns("statusPembayaran").ColumnName = "Status"


                    ds.Tables("Tindakan").Columns("noDaftar").ColumnName = "No.Registrasi"
                    ds.Tables("Tindakan").Columns("noDaftarRawatInap").ColumnName = "No. Daftar Rawat Inap"



                    ds.Tables("Tindakan").Columns("noTindakanPasienRanap").ColumnName = "No. Tindakan Pasien"
                    ds.Tables("Tindakan").Columns("tindakan").ColumnName = "Tindakan"
                    ds.Tables("Tindakan").Columns("tarif").ColumnName = "Tarif"
                    ds.Tables("Tindakan").Columns("jumlahTindakan").ColumnName = "Jumlah Tindakan"
                    ds.Tables("Tindakan").Columns("totalTarif").ColumnName = "TotalTarif"
                    ds.Tables("Tindakan").Columns("namapetugasMedis").ColumnName = "Petugas"

                    ds.Relations.Add("1", ds.Tables("Pasien").Columns("No. Tindakan Pasien"), ds.Tables("Tindakan").Columns("No. Tindakan Pasien"), False)


                    'ds.Relations.Add()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using

        Return ds

    End Function

#Region "Via Joined"
    Public Function UpdateStatusByIdentifier(ByVal pRow As DataRow) As Boolean
        Dim success As Boolean = True
        'Exc.mHasException = False

        Try
            Using cn As New MySqlConnection With {.ConnectionString = Connect.con}
                Using cmd As New MySqlCommand With {.Connection = cn}

                    cmd.CommandText = UpdateStatusBayarScript()
                    cmd.Parameters.AddWithValue("@statusPembayaran", pRow.Field(Of String)("statusPembayaran"))
                    cmd.Parameters.AddWithValue("@Identifier", pRow.Field(Of String)("noDaftar"))

                    cn.Open()

                    success = cmd.ExecuteNonQuery = 1

                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Exc.mHasException = True
            Exc.mLastException = ex
            success = False
        End Try

        Return success

    End Function
#End Region
    Public Function UpdateStatusTindakanByIdentifier(ByVal pRow As DataRow) As Boolean
        Dim success As Boolean = True
        'Exc.mHasException = False

        Try
            Using cn As New MySqlConnection With {.ConnectionString = Connect.con}
                Using cmd As New MySqlCommand With {.Connection = cn}

                    cmd.CommandText = UpdateStatusTindakanPasienRanap()
                    cmd.Parameters.AddWithValue("@statusPembayaran", pRow.Field(Of String)("statusPembayaran"))
                    cmd.Parameters.AddWithValue("@Identifier", pRow.Field(Of String)("noTindakanPasienRanap"))

                    cn.Open()

                    success = cmd.ExecuteNonQuery = 1

                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Exc.mHasException = True
            Exc.mLastException = ex
            success = False
        End Try

        Return success

    End Function
End Class
