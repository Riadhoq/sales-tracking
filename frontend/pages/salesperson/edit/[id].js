import {
  Alert,
  AlertIcon,
  Box,
  Button,
  Flex,
  FormControl,
  FormHelperText,
  FormLabel,
  Heading,
  Input,
  SimpleGrid,
  useToast,
} from "@chakra-ui/react";
import { useFormik } from "formik";
import { useState } from "react";

const SalespersonEdit = (props) => {
  const [serverResponse, setServerResponse] = useState(null);
  const toast = useToast();

  const formik = useFormik({
    initialValues: {
      salespersonId: props.salespersonId,
      address: props.address || "",
      firstName: props.firstName || "",
      lastName: props.lastName || "",
      phone: props.phone || "",
      startDate: new Date(props.startDate).toLocaleDateString() || "",
      terminationDate: props.terminationDate
        ? new Date(props.terminationDate).toLocaleDateString()
        : "",
      manager: props.manager || "",
    },
    onSubmit: async (values) => {
      try {
        values.startDate = new Date(values.startDate).toISOString();
        values.terminationDate = values.terminationDate
          ? new Date(values.terminationDate).toISOString()
          : undefined;

        var response = await fetch(
          `http://localhost:5000/api/salespeople/edit/${values.salespersonId}`,
          {
            method: "PUT",
            body: JSON.stringify(values),
            headers: {
              "Content-Type": "application/json",
            },
          }
        );
        if (response.status === 200) {
          {
            toast({
              title: "Update Successful",
              description: "Salesperson updated successfully",
              status: "success",
              duration: 2000,
              isClosable: true,
            });
          }
        }
        return setServerResponse(response);
      } catch (err) {
        return setServerResponse(error);
      }
    },
  });

  if (!props) {
    body = (
      <Box d="flex" justifyContent="center" justifyItems="center">
        Could not found any results to edit.
      </Box>
    );
  }

  return (
    <Flex px={10} py={10} maxW={800} mx="auto" gridGap="10px" wrap="wrap">
      <Heading color="gray.700" w="100%">
        Edit Salesperson
      </Heading>
      {serverResponse?.status == 200 ? (
        <Alert mt={2} borderRadius="md" status="success">
          <AlertIcon />
          Data uploaded to the server.
        </Alert>
      ) : null}
      <form style={{ width: `100%` }} onSubmit={formik.handleSubmit}>
        <SimpleGrid
          mt="3"
          w="100%"
          justifyContent="center"
          columns={1}
          spacing={5}
        >
          <Flex gridGap={5} justifyContent="center">
            <FormControl isRequired id="firstName">
              <FormLabel>First Name</FormLabel>
              <Input
                type="text"
                onChange={formik.handleChange}
                value={formik.values.firstName}
              />
            </FormControl>
            <FormControl isRequired id="lastName">
              <FormLabel>Last Name</FormLabel>
              <Input
                type="text"
                onChange={formik.handleChange}
                value={formik.values.lastName}
              />
            </FormControl>
          </Flex>
          <Flex justifyContent="center">
            <FormControl id="address">
              <FormLabel>Full Address</FormLabel>
              <Input
                type="text"
                onChange={formik.handleChange}
                value={formik.values.address}
              />
            </FormControl>
          </Flex>
          <Flex justifyContent="center">
            <FormControl id="phone">
              <FormLabel>Phone</FormLabel>
              <Input
                type="text"
                onChange={formik.handleChange}
                value={formik.values.phone}
              />
            </FormControl>
          </Flex>
          <Flex gridGap={5} justifyContent="center">
            <FormControl id="startDate">
              <FormLabel>Start Date</FormLabel>
              <Input
                type="text"
                onChange={formik.handleChange}
                value={formik.values.startDate}
              />
              <FormHelperText>Accepted format mm/dd/yyyy</FormHelperText>
            </FormControl>
            <FormControl id="terminationDate">
              <FormLabel>Termination Date</FormLabel>
              <Input
                type="text"
                onChange={formik.handleChange}
                value={formik.values.terminationDate}
              />
              <FormHelperText>Accepted format mm/dd/yyyy</FormHelperText>
            </FormControl>
          </Flex>
          <Flex justifyContent="center">
            <FormControl id="manager">
              <FormLabel>Manager</FormLabel>
              <Input
                type="text"
                onChange={formik.handleChange}
                value={formik.values.manager}
              />
            </FormControl>
          </Flex>
          <Flex justifyContent="center" mt="3">
            <Button
              disabled={formik.isSubmitting}
              bgColor="teal.400"
              px={3}
              color="teal.900"
              type="submit"
            >
              Save
            </Button>
          </Flex>
        </SimpleGrid>
      </form>
    </Flex>
  );
};

export async function getServerSideProps({ params }) {
  const res = await fetch(`http://localhost:5000/api/salespeople/${params.id}`);
  const data = await res.json();
  return { props: { ...data } };
}

export default SalespersonEdit;
