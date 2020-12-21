import React from "react";
import { Flex, Heading, Link } from "@chakra-ui/react";
import NextLink from "next/link";

export function Navbar() {
  return (
    <Flex
      position="sticky"
      top="0"
      alignItems="center"
      zIndex={1}
      bg="azure"
      p={4}
      w="100%"
    >
      <Flex maxW={1000} alignItems="center" flex={1} m="auto">
        <NextLink href="/">
          <Link d={{ base: "none", md: "block" }}>
            <Heading>Sales Tracker</Heading>
          </Link>
        </NextLink>
        <Flex wrap="wrap" m={{ base: "auto", md: 0 }} ml={{ md: "auto" }}>
          <NextLink href="/salespeople">
            <Link mr={2}>Salespeople</Link>
          </NextLink>
          <NextLink href="/products">
            <Link mr={2}>Products</Link>
          </NextLink>
          <NextLink href="/customers">
            <Link mr={2}>Customers</Link>
          </NextLink>
          <NextLink href="/sales">
            <Link>Sales</Link>
          </NextLink>
        </Flex>
      </Flex>
    </Flex>
  );
}
